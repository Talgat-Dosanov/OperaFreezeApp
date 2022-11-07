using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support.UI;
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

        string currentTabUrl { get; set; }
        string currentTab { get; set; }
        WebDriverWait wait;
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
                PageLoadStrategy = PageLoadStrategy.None
            };
            driver = new OperaDriver(Service, OperaOptions);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl("chrome://discards");
            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl("https://1xbit6.com/ru");

        }

        public void Test()
        {
            StartApp();
            Authorization(Settings.Email, Settings.Password);
            driver.Navigate().GoToUrl("https://1xbit6.com/line/basketball/13589-nba/151060485-home-points-away-points");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".c-dropdown.coupon__dropdown.coupon__dropdown--full.u-8pt-ph-0.c-dropdown--classic"))).Click();
            var toggleElement = driver.FindElement(By.CssSelector(".coupon-btn-group__item.save-coupon__input-wrap"));
            var inputEventId = toggleElement.FindElement(By.TagName("input"));
            inputEventId.SendKeys("QP4DR");

            var eventBtns = driver.FindElements(By.CssSelector(".c-btn.c-btn--block.c-btn--theme-brand"));
            wait.Until(ExpectedConditions.ElementToBeClickable(eventBtns[1])).Click();
            OpenNewTab();
            var driverPagesCount = driver.WindowHandles.Count();
            for(var i = 0; i < 5; i++)
            {
                while(driverPagesCount > 2)
                {
                    PageFreeze();
                    CloseLastTab();
                }
                OpenNewTab();
            }
            

        }
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Authorization (string email, string password)
        {
            // open authorization form
            var signIn = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("top-acc-btn__text")));
            if(ElemCheck(signIn))
            {
                signIn.Click();
            }
           
            var inputEmail = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("auth_id_email")));
            CheckInputItem(inputEmail, email);

            var inputPassword = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("auth-form-password")));
            CheckInputItem(inputPassword, password);

            var submitBtn = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".auth-button.auth-button--block.auth-button--slide-up-hover.auth-button--theme-secondary")));
            if(ElemCheck(submitBtn))
            {
                submitBtn.Click();
            }
            
        }
        public void PageFreeze()
        {
            currentTabUrl = driver.Url;
            currentTab = driver.CurrentWindowHandle;

                try
                {
                    var btnItems = driver.FindElement(By.ClassName("cpn-btns-group__item"));
                    var bet = btnItems.FindElement(By.TagName("button"));
                    bet.Click();
                    Thread.Sleep(1500);
                    driver.SwitchTo().Window(driver.WindowHandles.First());
                    var freezeBtn = ParseFreezeBtn();
                    freezeBtn.Click();
                    CheckFreeze(freezeBtn);
                    

                }
                catch (NoSuchElementException)
                {

                }
            
           
        }
      

                
        public void CheckFreeze(IWebElement btn)
        {
            try
            {
               
                IWebElement root1 = driver.FindElement(By.TagName("discards-main"));
                IWebElement shadowRoot1 = expandRootElement(root1);

                IWebElement root2 = shadowRoot1.FindElement(By.CssSelector("iron-pages"));
                IWebElement root3 = root2.FindElement(By.CssSelector("discards-tab"));

                IWebElement shadowRoot2 = expandRootElement(root3);

                var table = shadowRoot2.FindElement(By.Id("tab-discards-info-table-body"));
                var AllTab = table.FindElements(By.TagName("tr"));
                var status = AllTab[AllTab.Count() - 2].FindElements(By.TagName("td"))[7];
                while(status.Text != "frozen")
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(btn)).Click();
                }
                var name = "logs.txt";
                using (StreamWriter writer = new StreamWriter(name, true))
                {
                    writer.WriteLine($"{DateTime.Now.ToString("H:mm:ss")} - {status.Text}");
                }
            } catch (ElementClickInterceptedException)
            {
                
            }
           
        }
        public void OpenNewTab()
        {
            currentTabUrl = driver.Url;
            for (var i = 0; i < 3; i++)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                driver.Navigate().GoToUrl(currentTabUrl);
                
            }

            driver.SwitchTo().Window(driver.WindowHandles[1]);
          
        }
        public void CloseLastTab()
        {
            try
            {
                driver.SwitchTo().Window(driver.WindowHandles[1]);
                driver.Close();
                driver.SwitchTo().Window(driver.WindowHandles[1]);
            }
            catch (ArgumentOutOfRangeException)
            {

            }   
            
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

            var table = shadowRoot2.FindElement(By.Id("tab-discards-info-table-body"));
            var AllTab = table.FindElements(By.TagName("tr"));
            var activeTab = AllTab[AllTab.Count() - 2];
            var tabBtns = activeTab.FindElement(By.ClassName("actions-cell"));
            var freezeBtn = tabBtns.FindElements(By.CssSelector("div"));

            wait.Until(ExpectedConditions.ElementToBeClickable(freezeBtn[1]));
            return freezeBtn[1];
           
        }






    }
}
