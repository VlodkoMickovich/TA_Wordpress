using System;
using Test_Automation_Wordpress.Pages;
namespace Test_Automation_Wordpress.Logic
{
    class LoginPage_Logic
    {
        public string LogIn(string login, string password)
        {
            LoginPage lp = new LoginPage();
            lp.Click_login_input();
            lp.Clear_login_input();
            lp.SendKeys_login_input(login);

            lp.Click_password_input();
            lp.Clear_password_input();
            lp.SendKeys_password_input(password);
            lp.Click_button_exit();

            Updates.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            return Updates.driver.Url;
        }
       
        public string ClickLogo()
        {
            LoginPage lp = new LoginPage();
            lp.Click_buttonLogo();
            Updates.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return Updates.driver.Url;
        }
        public bool CheckRadioRememberMe()//Зробити через Assert()
        {
            LoginPage lp = new LoginPage();
            bool status = lp.IsVisible_radio_rememberMe();
            if (status == false)
            {
                lp.Click_radio_rememberMe();
                return true;
            }
            else
            {
                return false;
            }

        }
        public string Click_lostPassword()
        {
            LoginPage lp = new LoginPage();
            lp.Click_link_lostPassword();
            Updates.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return Updates.driver.Url;
        }
        public string Click_BackToSite()
        {
            LoginPage lp = new LoginPage();
            lp.Click_link_backToSite();
            Updates.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return Updates.driver.Url;
        }
    }
}
