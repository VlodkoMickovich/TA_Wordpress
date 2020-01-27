using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Test_Automation_Wordpress.Pages
{
    class Updates
    {
        public static IWebDriver driver = new ChromeDriver();

        IWebElement text_updates = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/h1"));
        IWebElement link_do_backUp = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/div/p/a[1]"));
        IWebElement link_updateWordpress = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/div/p/a[2]"));
        IWebElement button_checkNow = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/p[1]/a"));
        IWebElement text_newVersion = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/h2[1]"));
        IWebElement text_couldUpdateAutomaticallyTo = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[1]/p/text()[1]"));
        IWebElement link_downloadWordpress = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[1]/p/text()[1]"));
        IWebElement button_updateNow = driver.FindElement(By.XPath("//*[@id='upgrade']"));//Look at the element "_2_button_updateNow" because pathes is same
        IWebElement button_missThisUpdate = driver.FindElement(By.Id("dismiss"));
        IWebElement text_attention = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[1]/form/p[2]"));
        IWebElement _2_text_couldUpdateAutomaticallyTo = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[2]/p/text()[1]"));
        IWebElement _2_link_downloadWordpress = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[2]/p/a"));
        IWebElement _2_button_updateNow = driver.FindElement(By.XPath("//*[@id='upgrade']"));
        IWebElement text_whileUpdateSiteWillClose = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/p[2]"));


        //Athomic methods

        public void click_button_checkNow()
        {
            button_checkNow.Click();
        }
    }
}
