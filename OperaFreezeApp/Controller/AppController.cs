using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
        public IWebDriver driver { get; set; }
        public Settings Settings { get; set; }
        public SerializableSaver data { get; set; } = new SerializableSaver();

        public string currentTabUrl { get; set; }
        public string currentTab { get; set; }

        WebDriverWait wait;
        public AppController()
        {
            Settings = GetSettings();
        }
        public void StartApp(string url)
        {
            try
               { 
                Settings = GetSettings();
                Service = OperaDriverService.CreateDefaultService(Settings.OperaDriverPath, "operadriver.exe");
                OperaOptions = new OperaOptions
                {
                    BinaryLocation = Settings.OperaPath,
                    LeaveBrowserRunning = false,
                    PageLoadStrategy = PageLoadStrategy.Eager,
                };
                if (Settings.Proxy == true)
                {
                    var proxy = new Proxy();
                    proxy.Kind = ProxyKind.Manual;
                    proxy.IsAutoDetect = false;
                    proxy.SslProxy = $"{Settings.ProxyServer}:{Settings.ProxyPort}";
                    //proxy.SocksUserName = "login";
                    //proxy.SocksPassword = "password";
                    OperaOptions.Proxy = proxy;
                    OperaOptions.AddArgument("ignore-certificate-errors");
                }

                var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var userAgentPath = @"user-agent\0.3.2_0.crx";
                var fingerPrintsPath = @"fingerprints\0.2.0_0.crx";
                // Extensions Path
                OperaOptions.AddExtension(Path.Combine(appDir, userAgentPath));
                OperaOptions.AddExtension(Path.Combine(appDir, fingerPrintsPath));
                driver = new OperaDriver(Service, OperaOptions);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("chrome://discards");
               
                wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                driver.Navigate().GoToUrl(url);
            }
            catch (Exception)
            {
                
            }
           

        }
 
        public int SetIndex()
        {
            var index = driver.WindowHandles.IndexOf(driver.CurrentWindowHandle);
            if (driver.WindowHandles.IndexOf(driver.CurrentWindowHandle) < driver.WindowHandles.Count() - 1)
            {
                 index += 1;
            }
            else
            {
                index = 1;
            }
            return index;
        }
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOkBtn()
        {
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".swal2-confirm.swal2-styled"))).Click();
            }
            catch( Exception )
            {

            }
           
        }
        public void AuthorizationLineBet(string email, string password)
        {
            // open authorization form
            var signIn = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("curLoginForm")));
            if (ElemCheck(signIn))
            {
                signIn.Click();
            }

            var inputEmail = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("auth_id_email")));
            CheckInputItem(inputEmail, email);

            var inputPassword = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("auth-form-password")));
            CheckInputItem(inputPassword, password);

            var submitBtn = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".auth-button.auth-button--block.auth-button--slide-up-hover.auth-button--theme-secondary")));
            if (ElemCheck(submitBtn))
            {
                submitBtn.Click();
            }
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
     
        public void PageFreeze(int Index, string btnClass)
        {
            currentTabUrl = driver.Url;
            currentTab = driver.CurrentWindowHandle;

            try
            {
                if(driver.CurrentWindowHandle != driver.WindowHandles[Index])
                {
                    driver.SwitchTo().Window(driver.WindowHandles[Index]);
                }
                var btnItems = driver.FindElement(By.ClassName(btnClass));
                var bet = btnItems.FindElement(By.TagName("button"));
                bet.Click();
                Thread.Sleep(1000);
                driver.SwitchTo().Window(driver.WindowHandles.First());
                var freezeBtn = ParseFreezeBtn(Index);
                freezeBtn.Click();
                while (CheckStatus(freezeBtn, Index) != "forzen")
                {
                    freezeBtn.Click();
                }
                
            }
            catch (ElementClickInterceptedException)
            {
                
            }
            catch (NoSuchElementException) 
            {
               
            }
        }
      

                
        public string CheckStatus(IWebElement btn, int numPage)
        {
            
            IWebElement root1 = driver.FindElement(By.TagName("discards-main"));
            IWebElement shadowRoot1 = expandRootElement(root1);

            IWebElement root2 = shadowRoot1.FindElement(By.CssSelector("iron-pages"));
            IWebElement root3 = root2.FindElement(By.CssSelector("discards-tab"));

            IWebElement shadowRoot2 = expandRootElement(root3);

            var table = shadowRoot2.FindElement(By.Id("tab-discards-info-table-body"));
            var AllTab = table.FindElements(By.TagName("tr"));
            var status = AllTab[AllTab.Count() - (1+numPage)].FindElements(By.TagName("td"))[7];
        
            //var name = "logs.txt";
            //using (StreamWriter writer = new StreamWriter(name, true))
            //{
            //    writer.WriteLine($"{DateTime.Now.ToString("H:mm:ss")} - {status.Text}");
            //}

            return status.Text;
          
           
        }
        public void OpenNewTab()
        {
            try
            {
                currentTabUrl = driver.Url;
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                driver.Navigate().GoToUrl(currentTabUrl);

            }
            catch (Exception )
            {

            }
          
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
        public void WinTab(int Index)
        {
            driver.SwitchTo().Window(driver.WindowHandles[Index]);
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

        public IWebElement ParseFreezeBtn(int numPage)
        {
            
            IWebElement root1 = driver.FindElement(By.TagName("discards-main"));
            IWebElement shadowRoot1 = expandRootElement(root1);

            IWebElement root2 = shadowRoot1.FindElement(By.CssSelector("iron-pages"));
            IWebElement root3 = root2.FindElement(By.CssSelector("discards-tab"));

            IWebElement shadowRoot2 = expandRootElement(root3);

            var table = shadowRoot2.FindElement(By.Id("tab-discards-info-table-body"));
            var AllTab = table.FindElements(By.TagName("tr"));
            var activeTab = AllTab[AllTab.Count() - (1 + numPage)];
            var tabBtns = activeTab.FindElement(By.ClassName("actions-cell"));
            var freezeBtn = tabBtns.FindElements(By.CssSelector("div"));

            wait.Until(ExpectedConditions.ElementToBeClickable(freezeBtn[1]));
            return freezeBtn[1];
           
        }






    }
}
