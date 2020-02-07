using NUnit.Framework;
using Test_Automation_Wordpress.Pages;
using Test_Automation_Wordpress.Logic;
using System;


namespace Test_Automation_Wordpress
{
    [TestFixture]
    public class UpdatesPageTest
    {
        [SetUp]
        public void SetUp()
        {
            Updates.driver.Navigate().GoToUrl("http://localhost/wordpress/wp-admin/update-core.php?force-check=1");
            LoginPage_Logic lp = new LoginPage_Logic();
            lp.LogIn("vlodkomickovich@gmail.com", "vlodko27");

        }
        [TearDown]
        public void Teardown()
        {
            //Updates.driver.Close();
        }

        [Test]
        public void TestHeaderLinkBackUp()
        {
            UpdatePage_Logic u = new UpdatePage_Logic();
            string expected = "https://codex.wordpress.org/WordPress_Backups";
            string actual = u.ClickHeaderLinkBackUp();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestHeaderLinkUpdate()
        {
            UpdatePage_Logic u = new UpdatePage_Logic();

            string expected = "https://codex.wordpress.org/%D0%9E%D0%B1%D0%BD%D0%BE%D0%B2%D0%BB%D0%B5%D0%BD%D0%B8%D0%B5_WordPress";
            string actual = u.HeaderClickLink_UpdateWordPress();
            Assert.AreEqual(expected, actual); ;
        }

        [Test]
        public void TestButtonCheckNow()
        {
            UpdatePage_Logic u = new UpdatePage_Logic();
            DateTime a = DateTime.Now;
            string time = "Последняя проверка: " + a.ToString("dd/MM/yyyy") + " в " + a.ToString("HH:mm") + "   Проверить снова";
            string actual = u.HeaderClickButtonCheckNow();
            Assert.AreEqual(time, actual);
        }

        [Test]
        public void TestRadioPlugins()
        {
            UpdatePage_Logic u = new UpdatePage_Logic();
            int i = u.ClickRadioPlagins();

            Assert.AreEqual(i,1);
        }

        [Test]
        public void TestFooterLinks()
        {
            UpdatePage_Logic u = new UpdatePage_Logic();
            u.ClickingLinksFooter();
        }
    }
}