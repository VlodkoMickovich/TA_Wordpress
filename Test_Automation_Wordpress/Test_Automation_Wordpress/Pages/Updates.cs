using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Test_Automation_Wordpress.Pages
{
    class Updates
    {
        public static IWebDriver driver = new ChromeDriver();

        //Header
        IWebElement text_updates = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/h1"));
        IWebElement link_do_backUp = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/div/p/a[1]"));
        IWebElement link_updateWordpress = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/div/p/a[2]"));
        IWebElement button_checkNow = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/p[1]/a"));

        //First block (New version of Wordpresss)
        IWebElement text_newVersion = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/h2[1]"));
        IWebElement text_couldUpdateAutomaticallyTo = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[1]/p"));
        IWebElement link_downloadWordpress = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[1]/p/a"));
        IWebElement button_updateNow = driver.FindElement(By.XPath("//*[@id='upgrade']"));//Look at the element "_2_button_updateNow" because pathes is same
        IWebElement button_missThisUpdate = driver.FindElement(By.Id("dismiss"));
        IWebElement text_attention = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[1]/form/p[2]"));
        IWebElement _2_text_couldUpdateAutomaticallyTo = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[2]/p"));
        IWebElement _2_link_downloadWordpress = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/ul/li[2]/p/a"));
        IWebElement _2_button_updateNow = driver.FindElement(By.XPath("//*[@id='upgrade']"));
        IWebElement text_whileUpdateSiteWillClose = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/p[2]"));

        //Plagins
        IWebElement text_plagins = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/h2[2]"));
        IWebElement text_plaginUpdateIsAvailable = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/p[3]"));
        IWebElement button_updatePlagins = driver.FindElement(By.Id("upgrade-plugins"));
        IWebElement radio_selectAll = driver.FindElement(By.Id("plugins-select-all"));
        IWebElement radio_plaginAntiSpam = driver.FindElement(By.Id("checkbox_b2a77cb7afefcfe24ee09da469450cf3"));
        IWebElement _2_radio_selectAll = driver.FindElement(By.Id("plugins-select-all-2"));
        IWebElement _2_button_updatePlagins = driver.FindElement(By.Id("upgrade-plugins-2"));

        //Anti-spam plugin 
        IWebElement plugin_name = driver.FindElement(By.XPath("//*[@id='update-plugins-table']/tbody/tr/td[2]/p/strong"));
        IWebElement link_showInformation = driver.FindElement(By.XPath("//*[@id='update-plugins-table']/tbody/tr/td[2]/p/a"));
        //Обов'язково доробити елементи опису 

        //Footer

        IWebElement text_themes = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/h2[3]"));
        IWebElement text_inThemes = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/p[4]"));

        IWebElement text_translates = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/h2[4]"));
        IWebElement text_inTranslates = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/p[5]"));

        IWebElement text_thankYou = driver.FindElement(By.Id("footer-thankyou"));
        IWebElement link_wordPressFooter = driver.FindElement(By.XPath("//*[@id='footer-thankyou']/a"));
        IWebElement link_downloadNewVersion = driver.FindElement(By.XPath("//*[@id='footer-upgrade']/strong/a"));


        //Athomic methods

        //Header_Methods
        public string GetText_text_updates()
        {
            return text_updates.Text;
        }
        public void Click_link_do_backUp() 
        {
            link_do_backUp.Click();
        }
        public string GetText_link_do_backUp()
        {
            return link_do_backUp.Text;
        }
        public void Click_link_updateWordpress()
        {
            link_updateWordpress.Click();
        }
        public string GetText_link_updateWordpress()
        {
            return link_updateWordpress.Text;
        }
        public void Click_button_checkNow()
        {
            button_checkNow.Click();
        }

        //New version Wordpress(Body block)
        public string Get_text_newVersion()
        {
            return text_newVersion.Text;
        }
        public string Get_text_couldUpdateAutomaticallyTo()
        {
            return text_couldUpdateAutomaticallyTo.Text;
        }
        public void Click_link_downloadWordpress()
        {
            link_downloadWordpress.Click();
        }
        public string GetText_link_downloadWordpress()
        {
            return link_downloadWordpress.Text;
        }
        public void Clicl_button_updateNow()
        {
            button_updateNow.Click();
        }
        public void Click_button_missThisUpdate()
        {
            button_missThisUpdate.Click();
        }
        public string GetText_text_attention()
        {
            return text_attention.Text;
        }
        public string GetText_2_text_couldUpdateAutomaticallyTo()
        {
            return _2_text_couldUpdateAutomaticallyTo.Text;
        }
        public void Click_2_link_downloadWordpress()
        {
            _2_link_downloadWordpress.Click();
        }
        public string GetText_2_link_downloadWordpress()
        {
            return _2_link_downloadWordpress.Text;
        }
        public void Click_2_button_updateNow()
        {
            _2_button_updateNow.Click();
        }
        public string GetText_text_whileUpdateSiteWillClose()
        {
            return text_whileUpdateSiteWillClose.Text;
        }
        //Plugins 

        public string GetText_text_plagins()
        {
            return text_plagins.Text;
        }
        public string GetText_text_plaginUpdateIsAvailable()
        {
            return text_plaginUpdateIsAvailable.Text;
        }
        public void Click_button_updatePlagins()
        {
            button_updatePlagins.Click();
        }
        public void Click_radio_selectAll()
        {
            radio_selectAll.Click();
        }
        public bool IsSelected_radio_selectAll()
        {
            return radio_selectAll.Selected;
        }
        public void Click_radio_plaginAntiSpam()
        {
            radio_plaginAntiSpam.Click();
        }
        public bool IsSelected_radio_plaginAntiSpam()
        {
            return radio_plaginAntiSpam.Selected;
        }
        public void Click_2_radio_selectAll()
        {
            _2_radio_selectAll.Click();
        }
        public bool IsSelected_2_radio_selectAll()
        {
            return _2_radio_selectAll.Selected;
        }
        public void Click_2_button_updatePlagins()
        {
            _2_button_updatePlagins.Click();
        }
        public bool IsSelected_2_button_updatePlagins()
        {
            return _2_button_updatePlagins.Selected;
        }

        //Anti-spam plugin 
        public string GetText_plugin_name()
        {
            return plugin_name.Text;
        }
        public void Click_link_showInformation()
        {
            link_showInformation.Click();
        }
        public string GetText_link_showInformation()
        {
            return link_showInformation.Text;
        }

        //Footer
        public string GetText_text_themes()
        {
            return text_themes.Text;
        }
        public string GetText_text_inThemes()
        {
            return text_inThemes.Text;
        }
        public string GetText_text_translates()
        {
            return text_translates.Text;
        }
        public string GetText_text_inTranslates()
        {
            return text_inTranslates.Text;
        }
        public string GetText_text_thankYou()
        {
            return text_thankYou.Text;
        }
        public void Click_link_wordPressFooter()
        {
            link_wordPressFooter.Click();
        }
        public string GetText_link_wordPressFooter()
        {
            return link_wordPressFooter.Text;
        }
        public void Click_link_downloadNewVersion()
        {
            link_downloadNewVersion.Click();
        }
        public string GetText_link_downloadNewVersion()
        {
            return link_downloadNewVersion.Text;
        }


    }
}
