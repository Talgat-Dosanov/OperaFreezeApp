using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;
using OperaFreezeApp.Model;

namespace OperaFreezeApp
{
    public class AppController
    {
        OperaDriverService Service { get; set; }
        OperaOptions OperaOptions { get; set; }
        IWebDriver driver { get; set; }
        public Settings Settings { get; set; }
        public SerializableSaver data { get; set; } = new SerializableSaver();

        string currentTabUrl;
        string currentTab;
        public AppController()
        {
            Settings = GetSettings();
        }
        public void StartApp()
        {
            Settings = GetSettings();
            Service = OperaDriverService.CreateDefaultService(Settings.OperaDriverPath, "operadriver.exe");
            OperaOptions = new OperaOptions
            {
                BinaryLocation = Settings.OperaPath,
                LeaveBrowserRunning = false,
                PageLoadStrategy = PageLoadStrategy.Eager
            };
            driver = new OperaDriver(Service, OperaOptions);
            driver.Navigate().GoToUrl("chrome://discards");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Authorization (string email, string password)
        {
            // open authorization form
            var signIn = driver.FindElements(By.ClassName("top-acc-btn__text")).FirstOrDefault();
            if(ElemCheck(signIn))
            {
                signIn.Click();
            }
           
            var inputEmail = driver.FindElement(By.Id("auth_id_email"));
            CheckInputItem(inputEmail, email);

            var inputPassword = driver.FindElement(By.Id("auth-form-password"));
            CheckInputItem(inputPassword, password);

            var submitBtn = driver.FindElement(By.CssSelector(".auth-button.auth-button--block.auth-button--slide-up-hover.auth-button--theme-secondary"));
            if(ElemCheck(submitBtn))
            {
                submitBtn.Click();
            }
            
        }
        public void PageFreeze()
        {
            try
            {
                currentTabUrl = driver.Url;
                currentTab = driver.CurrentWindowHandle;
                var bet = driver.FindElement(By.CssSelector(".cpn-btn.cpn-btns-group__btn.cpn-btn--theme-accent.cpn-btn--size-m.cpn-btn--default"));
                bet.Click();
                driver.SwitchTo().Window(driver.WindowHandles.First());
                Thread.Sleep(1000);
                var freezeBtn = ParseFreezeBtn();
                freezeBtn.Click();

              
               
                
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
                return;
            }
        } 
        public void OpenNewTab()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl(currentTabUrl);
        }
        public void CloseLastTab()
        {;
            driver.SwitchTo().Window(currentTab);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
        public void WinTab()
        {
            driver.SwitchTo().Window(currentTab);
        }

        public Settings GetSettings()
        {
            return data.Load() ?? new Settings();
        }
        public void Save(Settings settings)
        {
            data.Save(settings);
        }

        public bool ElemCheck (IWebElement btn)
        {
            if(btn != default)
            {
                return true;
            }
            Console.WriteLine("Элемент не существует!");
            return false;
        }
        public void CheckInputItem(IWebElement inputItem, string userInfo)
        {
            if (ElemCheck(inputItem))
            {
                inputItem.Clear();
                inputItem.SendKeys(userInfo);
            }
        }

        // Find root elements
        IWebElement expandRootElement(IWebElement element)
        {
            IWebElement elem1 = (IWebElement)((IJavaScriptExecutor)driver)
                .ExecuteScript("return arguments[0].shadowRoot", element);
            return elem1;
        }

        public IWebElement ParseFreezeBtn()
        {
            IWebElement root1 = driver.FindElement(By.TagName("discards-main"));
            IWebElement shadowRoot1 = expandRootElement(root1);

            IWebElement root2 = shadowRoot1.FindElement(By.CssSelector("iron-pages"));
            IWebElement root3 = root2.FindElement(By.CssSelector("discards-tab"));

            IWebElement shadowRoot2 = expandRootElement(root3);

            var btnElement = shadowRoot2.FindElement(By.CssSelector(".actions-cell"));
            var freezeBtn = btnElement.FindElements(By.TagName("div"))[1];

            return freezeBtn;
           
        }






    }
}
