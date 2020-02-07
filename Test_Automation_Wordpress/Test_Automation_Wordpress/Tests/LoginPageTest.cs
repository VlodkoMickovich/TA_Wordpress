using NUnit.Framework;
using Test_Automation_Wordpress.Logic;
using Test_Automation_Wordpress.Pages;

namespace Test_Automation_Wordpress.Tests
{
    [TestFixture]//Почитати для чого потрібно
    class LoginPageTest
    {
        [SetUp]
        public void SetUp()
        {
            Updates.driver.Navigate().GoToUrl("http://localhost/wordpress/wp-login.php?redirect_to=http%3A%2F%2Flocalhost%2Fwordpress%2Fwp-admin%2Fupdate-core.php&reauth=1");
        }
        [Test]
        public void Test_Login()
        {
            LoginPage_Logic lp = new LoginPage_Logic();

            string actual = lp.LogIn("vlodkomickovich@gmail.com","vlodko27");
            string expected = "http://localhost/wordpress/wp-admin/update-core.php";

            Assert.AreEqual(actual,expected);
        }
        [Test]
        public void Test_logoButton()
        {
            LoginPage_Logic lp = new LoginPage_Logic();
            string actual = lp.ClickLogo();
            string expected = "https://ru.wordpress.org/";

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_RadioRememberMe()
        {
            LoginPage_Logic lp = new LoginPage_Logic();
            bool status = lp.CheckRadioRememberMe();

            Assert.AreEqual(status,true);
        }
        [Test]
        public void Test_linkLostPassword()
        {
            LoginPage_Logic lp = new LoginPage_Logic();
            string actual = lp.Click_lostPassword();
            string expected = "http://localhost/wordpress/wp-login.php?action=lostpassword";

            Assert.AreEqual(actual,expected);
        }
        [Test]
        public void Test_link_backToSite()
        {
            LoginPage_Logic lp = new LoginPage_Logic();
            string actual = lp.Click_BackToSite();
            string expected = "http://localhost/wordpress/";

            Assert.AreEqual(actual,expected);
        }
    }
}
