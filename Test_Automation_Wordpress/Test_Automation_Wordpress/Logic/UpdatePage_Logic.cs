using Test_Automation_Wordpress.Pages;
using System;

namespace Test_Automation_Wordpress.Logic
{
    class UpdatePage_Logic
    {
        public void HeaderClickLink_doBackUp()
        {
            Updates u = new Updates();
            u.Click_link_do_backUp();
        }
        public void HeaderClickLink_UpdateWordPress()
        {
            Updates u = new Updates();
            u.Click_link_updateWordpress();
        }
        public string HeaderClickButtonCheckNow()
        {   
            Updates u = new Updates();
            //u.Click_button_checkNow();
            return u.GetText_text_lastCheck();
        }
    }
}
