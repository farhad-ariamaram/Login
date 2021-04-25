using System;
using System.Collections.Generic;
using System.Linq;

namespace NewTest
{
    public partial class Menu : System.Web.UI.Page
    {
        DCDataContext db;

        public Menu()
        {
            db = new DCDataContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected List<MenuItem> GetItems()
        {

            int langid = (from b in db.Tbl_Sitestyle_Languages
                          where b.Fld_Sitestyle_Language_Text.Equals(Session["language"])
                          select b.Fld_Sitestyle_Language_Id).SingleOrDefault();

            var menus = from a in db.Tbl_Sitestyle_Menus
                        join b in db.Tbl_Sitestyle_MenuLanguages on a.Fld_Sitestyle_Menu_Id equals b.Fld_Sitestyle_MenuLanguage_MenuId
                        where b.Fld_Sitestyle_MenuLanguage_LanguageId == langid
                        select new MenuItem()
                        {
                            FontIcon = a.Fld_Sitestyle_Menu_FontIcon,
                            Hotkey = a.Fld_Sitestyle_Menu_Hotkey,
                            Text = a.Fld_Sitestyle_Menu_Text,
                            Title = b.Fld_Sitestyle_MenuLanguage_Title
                        };

            return menus.ToList();
        }


        protected string GetFont()
        {

            int langid = (from b in db.Tbl_Sitestyle_Languages
                          where b.Fld_Sitestyle_Language_Text.Equals(Session["language"])
                          select b.Fld_Sitestyle_Language_Id).SingleOrDefault();

            string font = (from a in db.Tbl_Sitestyle_Fonts
                           where a.Fld_Sitestyle_Font_LanguageId == langid
                           select a.Fld_Sitestyle_Font_Name).SingleOrDefault();

            return font;
        }

    }

    public class MenuItem
    {
        public string FontIcon { get; set; }
        public string Hotkey { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
    }
}