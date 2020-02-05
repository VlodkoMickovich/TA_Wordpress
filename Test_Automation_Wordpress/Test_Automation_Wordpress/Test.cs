using NUnit.Framework;
using Test_Automation_Wordpress.Pages;
using Test_Automation_Wordpress.Logic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;

namespace Test_Automation_Wordpress
{
    public class Test
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            //Винести окремо в файл логіки 
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
        public void TestLinkBackUp()
        {
            UpdatePage_Logic u = new UpdatePage_Logic();
            u.HeaderClickLink_doBackUp();
            string actual = Updates.driver.Url;
            string expected = "https://codex.wordpress.org/WordPress_Backups";
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestLinkUpdateWordPress()
        {
            UpdatePage_Logic u = new UpdatePage_Logic();
            u.HeaderClickLink_UpdateWordPress();
            string actual = Updates.driver.Url;
            string expected = "https://codex.wordpress.org/%D0%9E%D0%B1%D0%BD%D0%BE%D0%B2%D0%BB%D0%B5%D0%BD%D0%B8%D0%B5_WordPress";
            
            Assert.AreEqual(expected , actual);
        }

        [Test]
        public void TestButtonCheckNow()
        {
            UpdatePage_Logic u = new UpdatePage_Logic();
            //u.HeaderClickButtonCheckNow();
            DateTime a = DateTime.Now;
            string time = "Последняя проверка: " + a.ToString("dd/MM/yyyy") + " в " + a.ToString("HH:mm") + "   Проверить снова";
            string actual = u.HeaderClickButtonCheckNow();
            Assert.AreEqual(time,actual);
            
        }
        
    }
}