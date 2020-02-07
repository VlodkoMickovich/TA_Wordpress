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
            string actual_update = Updates.driver.Url; 
            return actual_update; 
        }
        public string ClickHeaderLinkBackUp()
        {
            Updates u = new Updates();
            u.Click_link_do_backUp();
            string actual_backUp = Updates.driver.Url;
      
            return actual_backUp;
        }
        public string HeaderClickButtonCheckNow()
        {   
            Updates u = new Updates();
            //u.Click_button_checkNow();
            return u.GetText_text_lastCheck();
        }
        public int ClickRadioPlagins() //Поки працює ок , але потрібно врахувати можливість кліку на інші кнопки(Зробити ще два методи )
        {                             //Доробити кнопки "Обновить сейчас"
            Updates u = new Updates();
            bool status_radioSelectAll1 = u.IsSelected_radio_selectAll();
            bool status_radioAntiSpam = u.IsSelected_radio_plaginAntiSpam();
            bool status_radioSelectAll2 = u.IsSelected_2_radio_selectAll();

            if(status_radioSelectAll1 == false) 
            {
                u.Click_radio_selectAll();
                return 1;
            }
            if(status_radioAntiSpam == true && status_radioSelectAll2 == true)
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
