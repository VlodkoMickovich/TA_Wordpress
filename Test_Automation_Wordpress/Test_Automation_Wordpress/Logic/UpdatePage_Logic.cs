using Test_Automation_Wordpress.Pages;
using System;

namespace Test_Automation_Wordpress.Logic
{
    class UpdatePage_Logic
    {
        //Logic only for functional test
        public void HeaderClickLink_doBackUp()
        {
            Updates u = new Updates();
            u.Click_link_do_backUp();
        }
        public string HeaderClickLink_UpdateWordPress()
        {
            Updates u1 = new Updates();
            u1.Click_link_updateWordpress();

            Updates.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return Updates.driver.Url;
        }
        public string ClickHeaderLinkBackUp()
        {
            Updates u = new Updates();
            u.Click_link_do_backUp();

            Updates.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            return Updates.driver.Url;
        }
        public string HeaderClickButtonCheckNow()
        {
            Updates u = new Updates();
            //u.Click_button_checkNow();
            return u.GetText_text_lastCheck();
        }
        public int ClickRadioPlagins()
        {
            Updates u = new Updates();
            bool status_radioSelectAll1 = u.IsSelected_radio_selectAll();
            bool status_radioAntiSpam = u.IsSelected_radio_plaginAntiSpam();
            bool status_radioSelectAll2 = u.IsSelected_2_radio_selectAll();

            if (status_radioSelectAll1 == false)
            {
                u.Click_radio_selectAll();
                return 1;
            }
            if (status_radioAntiSpam == true && status_radioSelectAll2 == true)
            {
                return 1;
            }
            return 0;

        }
        public void ClickingLinksFooter()
        {
            Updates u = new Updates();
            u.Click_link_wordPressFooter();
            Updates.driver.Navigate().Back();

            Updates u1 = new Updates();
            u1.Click_link_downloadNewVersion();
            Updates.driver.Navigate().Back();

        }
    }
}
