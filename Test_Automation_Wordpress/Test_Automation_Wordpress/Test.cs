using NUnit.Framework;
using System;
using Test_Automation_Wordpress.Pages;

namespace Test_Automation_Wordpress
{
    public class Test
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Updates.driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/update-core.php?force-check=1");
            LoginPage lp = new LoginPage();
            lp.click_login_input();
            lp.clear_login_input();
            lp.sendKeys_login_input("vlodkomickovich@gmail.com");
            lp.click_password_input();
            lp.clear_password_input();
            lp.sendKeys_password_input("vlodko27");
            lp.click_button_exit();

        }
        [TearDown]
        public void Teardown()
        {
            //Updates.driver.Quit();
        }

        [Test]
        public void Test1()
        {
            Updates u = new Updates();
            //u.click_button_checkNow();
            

        }
    }
}