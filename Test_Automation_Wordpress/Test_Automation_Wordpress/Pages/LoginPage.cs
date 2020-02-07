using OpenQA.Selenium;
using Test_Automation_Wordpress.Pages;

namespace Test_Automation_Wordpress.Pages
{
    class LoginPage
    {
        //Updates.driver
        IWebElement button_logo = Updates.driver.FindElement(By.XPath("//*[@id='login']/h1/a"));
        IWebElement login_input = Updates.driver.FindElement(By.Id("user_login"));
        IWebElement password_input = Updates.driver.FindElement(By.Id("user_pass"));
        IWebElement radio_rememberMe = Updates.driver.FindElement(By.Id("rememberme"));
        IWebElement button_exit = Updates.driver.FindElement(By.Id("wp-submit"));
        IWebElement link_lostPassword = Updates.driver.FindElement(By.XPath("//*[@id='nav']/a"));
        IWebElement link_backToSite = Updates.driver.FindElement(By.XPath("//*[@id='backtoblog']/a"));


        //Atomic methods 
        #region
        public void Click_buttonLogo()
        {
            button_logo.Click();
        }
        public void Click_login_input()
        {
            login_input.Click();
        }
        public void Clear_login_input()
        {
            login_input.Clear();
        }
        public void SendKeys_login_input(string str)
        {
            login_input.SendKeys(str);
        }
        public void Click_password_input()
        {
            password_input.Click();
        }
        public void Clear_password_input()
        {
            password_input.Clear();
        }
        public void SendKeys_password_input(string str)
        {
            password_input.SendKeys(str);
        }
        public void Click_radio_rememberMe()
        {
            radio_rememberMe.Click();
        }
        public bool IsVisible_radio_rememberMe()
        {
            return radio_rememberMe.Selected;
        }
        public void Click_button_exit()
        {
            button_exit.Click();
        }
        public void Click_link_lostPassword()
        {
            link_lostPassword.Click();
        }
        public void Click_link_backToSite()
        {
            link_backToSite.Click();
        }
        #endregion
    }
}
