using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
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


        public AppController(string operaBinary, string operaDriverBinary)
        {
            Service = OperaDriverService.CreateDefaultService(operaDriverBinary, "operadriver.exe");
            OperaOptions = new OperaOptions
            {
                BinaryLocation = operaBinary,
                LeaveBrowserRunning = false
            };
            driver = new OperaDriver(Service, OperaOptions);
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






    }
}
