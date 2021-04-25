using NewTest.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace NewTest
{
    public partial class WebServices : System.Web.UI.Page
    {

        //Delete Section

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteUserActivityGroup(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Users_UsersActivityGroups
                     where a.Fld_Users_UsersActivityGroup_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Users_UsersActivityGroups.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteUserActivityGroupLanguage(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Users_UsersActivityGroupLanguages
                     where a.Fld_Users_UsersActivityGroupLanguage_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Users_UsersActivityGroupLanguages.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteAlert(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Alerts
                     where a.Fld_Sitestyle_Alert_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Alerts.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteAlerttype(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Alerttypes
                     where a.Fld_Sitestyle_Alerttype_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Alerttypes.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteAlertLanguage(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_AlertLanguages
                     where a.Fld_Sitestyle_AlertLanguage_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_AlertLanguages.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteAlertType(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Alerttypes
                     where a.Fld_Sitestyle_Alerttype_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Alerttypes.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteCss(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Csses
                     where a.Fld_Sitestyle_Css_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Csses.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteFont(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Fonts
                     where a.Fld_Sitestyle_Font_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Fonts.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteIso1(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Iso639_1s
                     where a.Fld_Sitestyle_Iso639_1_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Iso639_1s.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteIso2(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Iso639_2s
                     where a.Fld_Sitestyle_Iso639_2_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Iso639_2s.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteIso3(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Iso639_3s
                     where a.Fld_Sitestyle_Iso639_3_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Iso639_3s.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteLanguage(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Languages
                     where a.Fld_Sitestyle_Language_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Languages.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteMenuLanguage(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_MenuLanguages
                     where a.Fld_Sitestyle_MenuLanguage_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_MenuLanguages.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteMenu(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Menus
                     where a.Fld_Sitestyle_Menu_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Menus.DeleteOnSubmit(q);
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void deleteMetadata(string id)
        {
            DCDataContext db = new DCDataContext();
            var q = (from a in db.Tbl_Sitestyle_Metadatas
                     where a.Fld_Sitestyle_Metadata_Id == Convert.ToInt32(id)
                     select a).FirstOrDefault();
            db.Tbl_Sitestyle_Metadatas.DeleteOnSubmit(q);
            db.SubmitChanges();
        }


        //Read By Id

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<UserActivityGroup> readUserActivityGroupById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Users_UsersActivityGroups
                        where a.Fld_Users_UsersActivityGroup_Id == Convert.ToInt32(id)
                        select new UserActivityGroup()
                        {
                            _Fld_Users_UsersActivityGroup_Id = a.Fld_Users_UsersActivityGroup_Id,
                            _Fld_Users_UsersActivityGroup_Title = a.Fld_Users_UsersActivityGroup_Title
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<UserActivityGroupLanguage> readUserActivityGroupLanguageById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Users_UsersActivityGroupLanguages
                        where a.Fld_Users_UsersActivityGroupLanguage_Id == Convert.ToInt32(id)
                        select new UserActivityGroupLanguage()
                        {
                            _Fld_Users_UsersActivityGroupLanguage_Id = a.Fld_Users_UsersActivityGroupLanguage_Id,
                            _Fld_Users_UsersActivityGroupLanguage_Title = a.Fld_Users_UsersActivityGroupLanguage_Title,
                            _Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId = a.Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId,
                            _Fld_Users_UsersActivityGroupLanguage_LanguageId = a.Fld_Users_UsersActivityGroupLanguage_LanguageId
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Alert> readAlertById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Alerts
                        where a.Fld_Sitestyle_Alert_Id == Convert.ToInt32(id)
                        select new Alert()
                        {
                            _Fld_Sitestyle_Alert_Id = a.Fld_Sitestyle_Alert_Id,
                            _Fld_Sitestyle_Alert_Title = a.Fld_Sitestyle_Alert_Title,
                            _Fld_Sitestyle_Alert_Code = a.Fld_Sitestyle_Alert_Code,
                            _Fld_Sitestyle_Alert_AlerttypeId = a.Fld_Sitestyle_Alert_AlerttypeId
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<AlertLanguage> readAlertLanguageById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_AlertLanguages
                        where a.Fld_Sitestyle_AlertLanguage_Id == Convert.ToInt32(id)
                        select new AlertLanguage()
                        {
                            _Fld_Sitestyle_AlertLanguage_Id = a.Fld_Sitestyle_AlertLanguage_Id,
                            _Fld_Sitestyle_AlertLanguage_Title = a.Fld_Sitestyle_AlertLanguage_Title,
                            _Fld_Sitestyle_AlertLanguage_Text = a.Fld_Sitestyle_AlertLanguage_Text,
                            _Fld_Sitestyle_AlertLanguage_AlertId = a.Fld_Sitestyle_AlertLanguage_AlertId,
                            _Fld_Sitestyle_AlertLanguage_LanguageId = a.Fld_Sitestyle_AlertLanguage_LanguageId
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Alerttype> readAlerttypeById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Alerttypes
                        where a.Fld_Sitestyle_Alerttype_Id == Convert.ToInt32(id)
                        select new Alerttype()
                        {
                            _Fld_Sitestyle_Alerttype_Id = a.Fld_Sitestyle_Alerttype_Id,
                            _Fld_Sitestyle_Alerttype_Name = a.Fld_Sitestyle_Alerttype_Name,
                            _Fld_Sitestyle_Alerttype_Icon = a.Fld_Sitestyle_Alerttype_Icon
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Css> readCssById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Csses
                        where a.Fld_Sitestyle_Css_Id == Convert.ToInt32(id)
                        select new Css()
                        {
                            _Fld_Sitestyle_Css_Id = a.Fld_Sitestyle_Css_Id,
                            _Fld_Sitestyle_Css_Name = a.Fld_Sitestyle_Css_Name,
                            _Fld_Sitestyle_Css_LanguageId = a.Fld_Sitestyle_Css_LanguageId
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Font> readFontById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Fonts
                        where a.Fld_Sitestyle_Font_Id == Convert.ToInt32(id)
                        select new Font()
                        {
                            _Fld_Sitestyle_Font_Id = a.Fld_Sitestyle_Font_Id,
                            _Fld_Sitestyle_Font_Name = a.Fld_Sitestyle_Font_Name,
                            _Fld_Sitestyle_Font_LanguageId = a.Fld_Sitestyle_Font_LanguageId
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_1> readIso639_1ById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_1s
                        where a.Fld_Sitestyle_Iso639_1_Id == Convert.ToInt32(id)
                        select new Iso639_1()
                        {
                            _Fld_Sitestyle_Iso639_1_Id = a.Fld_Sitestyle_Iso639_1_Id,
                            _Fld_Sitestyle_Iso639_1_Code = a.Fld_Sitestyle_Iso639_1_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_2> readIso639_2ById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_2s
                        where a.Fld_Sitestyle_Iso639_2_Id == Convert.ToInt32(id)
                        select new Iso639_2()
                        {
                            _Fld_Sitestyle_Iso639_2_Id = a.Fld_Sitestyle_Iso639_2_Id,
                            _Fld_Sitestyle_Iso639_2_Code = a.Fld_Sitestyle_Iso639_2_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_3> readIso639_3ById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_3s
                        where a.Fld_Sitestyle_Iso639_3_Id == Convert.ToInt32(id)
                        select new Iso639_3()
                        {
                            _Fld_Sitestyle_Iso639_3_Id = a.Fld_Sitestyle_Iso639_3_Id,
                            _Fld_Sitestyle_Iso639_3_Code = a.Fld_Sitestyle_Iso639_3_Code

                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Language> readLanguageById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Languages
                        where a.Fld_Sitestyle_Language_Id == Convert.ToInt32(id)
                        select new Language()
                        {
                            _Fld_Sitestyle_Language_Id = a.Fld_Sitestyle_Language_Id,
                            _Fld_Sitestyle_Language_Direction = a.Fld_Sitestyle_Language_Direction,
                            _Fld_Sitestyle_Language_Text = a.Fld_Sitestyle_Language_Text,
                            _Fld_Sitestyle_Language_Iso639_1_Id = a.Fld_Sitestyle_Language_Iso639_1_Id,
                            _Fld_Sitestyle_Language_Iso639_2_Id = a.Fld_Sitestyle_Language_Iso639_2_Id,
                            _Fld_Sitestyle_Language_Iso639_3_Id = a.Fld_Sitestyle_Language_Iso639_3_Id
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Menus> readMenuById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Menus
                        where a.Fld_Sitestyle_Menu_Id == Convert.ToInt32(id)
                        select new Menus()
                        {
                            _Fld_Sitestyle_Menu_Id = a.Fld_Sitestyle_Menu_Id,
                            _Fld_Sitestyle_Menu_Text = a.Fld_Sitestyle_Menu_Text,
                            _Fld_Sitestyle_Menu_Hotkey = a.Fld_Sitestyle_Menu_Hotkey,
                            _Fld_Sitestyle_Menu_FontIcon = a.Fld_Sitestyle_Menu_FontIcon,
                            _Fld_Sitestyle_Menu_ImageIcon = a.Fld_Sitestyle_Menu_ImageIcon,
                            _Fld_Sitestyle_Menu_AccessId = a.Fld_Sitestyle_Menu_AccessId
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<MenuLanguage> readMenuLanguageById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_MenuLanguages
                        where a.Fld_Sitestyle_MenuLanguage_Id == Convert.ToInt32(id)
                        select new MenuLanguage()
                        {
                            _Fld_Sitestyle_MenuLanguage_Id = a.Fld_Sitestyle_MenuLanguage_Id,
                            _Fld_Sitestyle_MenuLanguage_Title = a.Fld_Sitestyle_MenuLanguage_Title,
                            _Fld_Sitestyle_MenuLanguage_Tooltip = a.Fld_Sitestyle_MenuLanguage_Tooltip,
                            _Fld_Sitestyle_MenuLanguage_LanguageId = a.Fld_Sitestyle_MenuLanguage_LanguageId,
                            _Fld_Sitestyle_MenuLanguage_MenuId = a.Fld_Sitestyle_MenuLanguage_MenuId
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Metadata> readMetadataById(string id)
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Metadatas
                        where a.Fld_Sitestyle_Metadata_Id == Convert.ToInt32(id)
                        select new Metadata()
                        {
                            _Fld_Sitestyle_Metadata_Id = a.Fld_Sitestyle_Metadata_Id,
                            _Fld_Sitestyle_Metadata_Text = a.Fld_Sitestyle_Metadata_Text,
                            _Fld_Sitestyle_Metadata_LanguageId = a.Fld_Sitestyle_Metadata_LanguageId
                        };
            return query.ToList();
        }

        //Update Section

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateUserActivityGroup(UserActivityGroup obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Users_UsersActivityGroups
                          where a.Fld_Users_UsersActivityGroup_Id == obj._Fld_Users_UsersActivityGroup_Id
                          select a).SingleOrDefault();
            result.Fld_Users_UsersActivityGroup_Title = obj._Fld_Users_UsersActivityGroup_Title;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateUserActivityGroupLanguage(UserActivityGroupLanguage obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Users_UsersActivityGroupLanguages
                          where a.Fld_Users_UsersActivityGroupLanguage_Id == obj._Fld_Users_UsersActivityGroupLanguage_Id
                          select a).SingleOrDefault();
            result.Fld_Users_UsersActivityGroupLanguage_Title = obj._Fld_Users_UsersActivityGroupLanguage_Title;
            result.Fld_Users_UsersActivityGroupLanguage_LanguageId = obj._Fld_Users_UsersActivityGroupLanguage_LanguageId;
            result.Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId = obj._Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateAlert(Alert obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Alerts
                          where a.Fld_Sitestyle_Alert_Id == obj._Fld_Sitestyle_Alert_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Alert_Title = obj._Fld_Sitestyle_Alert_Title;
            result.Fld_Sitestyle_Alert_Code = obj._Fld_Sitestyle_Alert_Code;
            result.Fld_Sitestyle_Alert_AlerttypeId = obj._Fld_Sitestyle_Alert_AlerttypeId;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateAlertLanguage(AlertLanguage obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_AlertLanguages
                          where a.Fld_Sitestyle_AlertLanguage_Id == obj._Fld_Sitestyle_AlertLanguage_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_AlertLanguage_Title = obj._Fld_Sitestyle_AlertLanguage_Title;
            result.Fld_Sitestyle_AlertLanguage_Text = obj._Fld_Sitestyle_AlertLanguage_Text;
            result.Fld_Sitestyle_AlertLanguage_LanguageId = obj._Fld_Sitestyle_AlertLanguage_LanguageId;
            result.Fld_Sitestyle_AlertLanguage_AlertId = obj._Fld_Sitestyle_AlertLanguage_AlertId;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateAlerttype(Alerttype obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Alerttypes
                          where a.Fld_Sitestyle_Alerttype_Id == obj._Fld_Sitestyle_Alerttype_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Alerttype_Name = obj._Fld_Sitestyle_Alerttype_Name;
            result.Fld_Sitestyle_Alerttype_Icon = obj._Fld_Sitestyle_Alerttype_Icon;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateCss(Css obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Csses
                          where a.Fld_Sitestyle_Css_Id == obj._Fld_Sitestyle_Css_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Css_Name = obj._Fld_Sitestyle_Css_Name;
            result.Fld_Sitestyle_Css_LanguageId = obj._Fld_Sitestyle_Css_LanguageId;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateFont(Font obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Fonts
                          where a.Fld_Sitestyle_Font_Id == obj._Fld_Sitestyle_Font_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Font_Name = obj._Fld_Sitestyle_Font_Name;
            result.Fld_Sitestyle_Font_LanguageId = obj._Fld_Sitestyle_Font_LanguageId;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateIso1(Iso639_1 obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Iso639_1s
                          where a.Fld_Sitestyle_Iso639_1_Id == obj._Fld_Sitestyle_Iso639_1_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Iso639_1_Code = obj._Fld_Sitestyle_Iso639_1_Code;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateIso2(Iso639_2 obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Iso639_2s
                          where a.Fld_Sitestyle_Iso639_2_Id == obj._Fld_Sitestyle_Iso639_2_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Iso639_2_Code = obj._Fld_Sitestyle_Iso639_2_Code;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateIso3(Iso639_3 obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Iso639_3s
                          where a.Fld_Sitestyle_Iso639_3_Id == obj._Fld_Sitestyle_Iso639_3_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Iso639_3_Code = obj._Fld_Sitestyle_Iso639_3_Code;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateLanguage(Language obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Languages
                          where a.Fld_Sitestyle_Language_Id == obj._Fld_Sitestyle_Language_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Language_Direction = obj._Fld_Sitestyle_Language_Direction;
            result.Fld_Sitestyle_Language_Text = obj._Fld_Sitestyle_Language_Text;
            result.Fld_Sitestyle_Language_Iso639_1_Id = obj._Fld_Sitestyle_Language_Iso639_1_Id;
            result.Fld_Sitestyle_Language_Iso639_2_Id = obj._Fld_Sitestyle_Language_Iso639_2_Id;
            result.Fld_Sitestyle_Language_Iso639_3_Id = obj._Fld_Sitestyle_Language_Iso639_3_Id;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateMenu(Menus obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Menus
                          where a.Fld_Sitestyle_Menu_Id == obj._Fld_Sitestyle_Menu_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Menu_Text = obj._Fld_Sitestyle_Menu_Text;
            result.Fld_Sitestyle_Menu_Hotkey = obj._Fld_Sitestyle_Menu_Hotkey;
            result.Fld_Sitestyle_Menu_FontIcon = obj._Fld_Sitestyle_Menu_FontIcon;
            result.Fld_Sitestyle_Menu_ImageIcon = obj._Fld_Sitestyle_Menu_ImageIcon;
            result.Fld_Sitestyle_Menu_AccessId = obj._Fld_Sitestyle_Menu_AccessId;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateMenuLanguage(MenuLanguage obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_MenuLanguages
                          where a.Fld_Sitestyle_MenuLanguage_Id == obj._Fld_Sitestyle_MenuLanguage_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_MenuLanguage_Title = obj._Fld_Sitestyle_MenuLanguage_Title;
            result.Fld_Sitestyle_MenuLanguage_Tooltip = obj._Fld_Sitestyle_MenuLanguage_Tooltip;
            result.Fld_Sitestyle_MenuLanguage_MenuId = obj._Fld_Sitestyle_MenuLanguage_MenuId;
            result.Fld_Sitestyle_MenuLanguage_LanguageId = obj._Fld_Sitestyle_MenuLanguage_LanguageId;

            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void updateMetadata(Metadata obj)
        {
            DCDataContext db = new DCDataContext();
            var result = (from a in db.Tbl_Sitestyle_Metadatas
                          where a.Fld_Sitestyle_Metadata_Id == obj._Fld_Sitestyle_Metadata_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Metadata_Text = obj._Fld_Sitestyle_Metadata_Text;
            result.Fld_Sitestyle_Metadata_LanguageId = obj._Fld_Sitestyle_Metadata_LanguageId;

            db.SubmitChanges();
        }

        //Read Section

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<UserActivityGroup> readUserActivityGroup()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Users_UsersActivityGroups
                        select new UserActivityGroup()
                        {
                            _Fld_Users_UsersActivityGroup_Id = a.Fld_Users_UsersActivityGroup_Id,
                            _Fld_Users_UsersActivityGroup_Title = a.Fld_Users_UsersActivityGroup_Title
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<RUserActivityGroupLanguage> readUserActivityGroupLanguage()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Users_UsersActivityGroupLanguages
                        select new RUserActivityGroupLanguage()
                        {
                            _Fld_Users_UsersActivityGroupLanguage_Id = a.Fld_Users_UsersActivityGroupLanguage_Id,
                            _Fld_Users_UsersActivityGroupLanguage_Title = a.Fld_Users_UsersActivityGroupLanguage_Title,
                            _Fld_Users_UsersActivityGroupLanguage_Language = a.Tbl_Sitestyle_Language.Fld_Sitestyle_Language_Text,
                            _Fld_Users_UsersActivityGroupLanguage_UsersActivityGroup = a.Tbl_Users_UsersActivityGroup.Fld_Users_UsersActivityGroup_Title
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<RAlert> readAlert()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Alerts
                        select new RAlert()
                        {
                            _Fld_Sitestyle_Alert_Id = a.Fld_Sitestyle_Alert_Id,
                            _Fld_Sitestyle_Alert_Title = a.Fld_Sitestyle_Alert_Title,
                            _Fld_Sitestyle_Alert_Code = a.Fld_Sitestyle_Alert_Code,
                            _Fld_Sitestyle_Alert_Alerttype = a.Tbl_Sitestyle_Alerttype.Fld_Sitestyle_Alerttype_Name
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<RAlertLanguage> readAlertLanguage()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_AlertLanguages
                        select new RAlertLanguage()
                        {
                            _Fld_Sitestyle_AlertLanguage_Id = a.Fld_Sitestyle_AlertLanguage_Id,
                            _Fld_Sitestyle_AlertLanguage_Title = a.Fld_Sitestyle_AlertLanguage_Title,
                            _Fld_Sitestyle_AlertLanguage_Text = a.Fld_Sitestyle_AlertLanguage_Text,
                            _Fld_Sitestyle_AlertLanguage_Alert = a.Tbl_Sitestyle_Alert.Fld_Sitestyle_Alert_Title,
                            _Fld_Sitestyle_AlertLanguage_Language = a.Tbl_Sitestyle_Language.Fld_Sitestyle_Language_Text
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Alerttype> readAlerttype()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Alerttypes
                        select new Alerttype()
                        {
                            _Fld_Sitestyle_Alerttype_Id = a.Fld_Sitestyle_Alerttype_Id,
                            _Fld_Sitestyle_Alerttype_Name = a.Fld_Sitestyle_Alerttype_Name,
                            _Fld_Sitestyle_Alerttype_Icon = a.Fld_Sitestyle_Alerttype_Icon
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<RCss> readCss()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Csses
                        select new RCss()
                        {
                            _Fld_Sitestyle_Css_Id = a.Fld_Sitestyle_Css_Id,
                            _Fld_Sitestyle_Css_Name = a.Fld_Sitestyle_Css_Name,
                            _Fld_Sitestyle_Css_Language = a.Tbl_Sitestyle_Language.Fld_Sitestyle_Language_Text
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<RFont> readFont()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Fonts
                        select new RFont()
                        {
                            _Fld_Sitestyle_Font_Id = a.Fld_Sitestyle_Font_Id,
                            _Fld_Sitestyle_Font_Name = a.Fld_Sitestyle_Font_Name,
                            _Fld_Sitestyle_Font_Language = a.Tbl_Sitestyle_Language.Fld_Sitestyle_Language_Text
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_1> readIso639_1()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_1s
                        select new Iso639_1()
                        {
                            _Fld_Sitestyle_Iso639_1_Id = a.Fld_Sitestyle_Iso639_1_Id,
                            _Fld_Sitestyle_Iso639_1_Code = a.Fld_Sitestyle_Iso639_1_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_2> readIso639_2()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_2s
                        select new Iso639_2()
                        {
                            _Fld_Sitestyle_Iso639_2_Id = a.Fld_Sitestyle_Iso639_2_Id,
                            _Fld_Sitestyle_Iso639_2_Code = a.Fld_Sitestyle_Iso639_2_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_3> readIso639_3()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_3s
                        select new Iso639_3()
                        {
                            _Fld_Sitestyle_Iso639_3_Id = a.Fld_Sitestyle_Iso639_3_Id,
                            _Fld_Sitestyle_Iso639_3_Code = a.Fld_Sitestyle_Iso639_3_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<RLanguage> readLanguage()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Languages
                        select new RLanguage()
                        {
                            _Fld_Sitestyle_Language_Id = a.Fld_Sitestyle_Language_Id,
                            _Fld_Sitestyle_Language_Direction = a.Fld_Sitestyle_Language_Direction,
                            _Fld_Sitestyle_Language_Text = a.Fld_Sitestyle_Language_Text,
                            _Fld_Sitestyle_Language_Iso639_1 = a.Tbl_Sitestyle_Iso639_1.Fld_Sitestyle_Iso639_1_Code,
                            _Fld_Sitestyle_Language_Iso639_2 = a.Tbl_Sitestyle_Iso639_2.Fld_Sitestyle_Iso639_2_Code,
                            _Fld_Sitestyle_Language_Iso639_3 = a.Tbl_Sitestyle_Iso639_3.Fld_Sitestyle_Iso639_3_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Menus> readMenu()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Menus
                        select new Menus()
                        {
                            _Fld_Sitestyle_Menu_Id = a.Fld_Sitestyle_Menu_Id,
                            _Fld_Sitestyle_Menu_Text = a.Fld_Sitestyle_Menu_Text,
                            _Fld_Sitestyle_Menu_Hotkey = a.Fld_Sitestyle_Menu_Hotkey,
                            _Fld_Sitestyle_Menu_FontIcon = a.Fld_Sitestyle_Menu_FontIcon,
                            _Fld_Sitestyle_Menu_ImageIcon = a.Fld_Sitestyle_Menu_ImageIcon,
                            _Fld_Sitestyle_Menu_AccessId = a.Fld_Sitestyle_Menu_AccessId
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<RMenuLanguage> readMenuLanguage()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_MenuLanguages
                        select new RMenuLanguage()
                        {
                            _Fld_Sitestyle_MenuLanguage_Id = a.Fld_Sitestyle_MenuLanguage_Id,
                            _Fld_Sitestyle_MenuLanguage_Title = a.Fld_Sitestyle_MenuLanguage_Title,
                            _Fld_Sitestyle_MenuLanguage_Tooltip = a.Fld_Sitestyle_MenuLanguage_Tooltip,
                            _Fld_Sitestyle_MenuLanguage_Language = a.Tbl_Sitestyle_Language.Fld_Sitestyle_Language_Text,
                            _Fld_Sitestyle_MenuLanguage_Menu = a.Tbl_Sitestyle_Menu.Fld_Sitestyle_Menu_Text
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<RMetadata> readMetadata()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Metadatas
                        select new RMetadata()
                        {
                            _Fld_Sitestyle_Metadata_Id = a.Fld_Sitestyle_Metadata_Id,
                            _Fld_Sitestyle_Metadata_Text = a.Fld_Sitestyle_Metadata_Text,
                            _Fld_Sitestyle_Metadata_Language = a.Tbl_Sitestyle_Language.Fld_Sitestyle_Language_Text
                        };
            return query.ToList();
        }


        //Read For Dropdown Menu

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<DDUserActivityGroup> readUserActivityGroupDropdown()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Users_UsersActivityGroups
                        select new DDUserActivityGroup()
                        {
                            _Fld_Users_UsersActivityGroup_Id = a.Fld_Users_UsersActivityGroup_Id,
                            _Fld_Users_UsersActivityGroup_Title = a.Fld_Users_UsersActivityGroup_Title
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<DDLanguage> readLanguageDropdown()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Languages
                        select new DDLanguage()
                        {
                            _Fld_Sitestyle_Language_Id = a.Fld_Sitestyle_Language_Id,
                            _Fld_Sitestyle_Language_Text = a.Fld_Sitestyle_Language_Text
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<DDAlert> readAlertDropdown()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Alerts
                        select new DDAlert()
                        {
                            _Fld_Sitestyle_Alert_Id = a.Fld_Sitestyle_Alert_Id,
                            _Fld_Sitestyle_Alert_Title = a.Fld_Sitestyle_Alert_Title
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<DDAlerttype> readAlertTypeDropdown()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Alerttypes
                        select new DDAlerttype()
                        {
                            _Fld_Sitestyle_Alerttype_Id = a.Fld_Sitestyle_Alerttype_Id,
                            _Fld_Sitestyle_Alerttype_Name = a.Fld_Sitestyle_Alerttype_Name
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_1> readIso1Dropdown()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_1s
                        select new Iso639_1()
                        {
                            _Fld_Sitestyle_Iso639_1_Id = a.Fld_Sitestyle_Iso639_1_Id,
                            _Fld_Sitestyle_Iso639_1_Code = a.Fld_Sitestyle_Iso639_1_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_2> readIso2Dropdown()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_2s
                        select new Iso639_2()
                        {
                            _Fld_Sitestyle_Iso639_2_Id = a.Fld_Sitestyle_Iso639_2_Id,
                            _Fld_Sitestyle_Iso639_2_Code = a.Fld_Sitestyle_Iso639_2_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Iso639_3> readIso3Dropdown()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Iso639_3s
                        select new Iso639_3()
                        {
                            _Fld_Sitestyle_Iso639_3_Id = a.Fld_Sitestyle_Iso639_3_Id,
                            _Fld_Sitestyle_Iso639_3_Code = a.Fld_Sitestyle_Iso639_3_Code
                        };
            return query.ToList();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static List<Menus> readMenuDropdown()
        {
            DCDataContext db = new DCDataContext();
            var query = from a in db.Tbl_Sitestyle_Menus
                        select new Menus()
                        {
                            _Fld_Sitestyle_Menu_Id = a.Fld_Sitestyle_Menu_Id,
                            _Fld_Sitestyle_Menu_Text = a.Fld_Sitestyle_Menu_Text
                        };
            return query.ToList();
        }


        // Create Section

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createUserActivityGroup(UserActivityGroup obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Users_UsersActivityGroups
                          orderby a.Fld_Users_UsersActivityGroup_Id descending
                          select a.Fld_Users_UsersActivityGroup_Id).FirstOrDefault();

            db.Tbl_Users_UsersActivityGroups.InsertOnSubmit(new Tbl_Users_UsersActivityGroup
            {
                Fld_Users_UsersActivityGroup_Id = lastId + 1,
                Fld_Users_UsersActivityGroup_Title = obj._Fld_Users_UsersActivityGroup_Title
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createUserActivityGroupLanguage(UserActivityGroupLanguage obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Users_UsersActivityGroupLanguages
                          orderby a.Fld_Users_UsersActivityGroupLanguage_Id descending
                          select a.Fld_Users_UsersActivityGroupLanguage_Id).FirstOrDefault();

            db.Tbl_Users_UsersActivityGroupLanguages.InsertOnSubmit(new Tbl_Users_UsersActivityGroupLanguage
            {
                Fld_Users_UsersActivityGroupLanguage_Id = lastId + 1,
                Fld_Users_UsersActivityGroupLanguage_Title = obj._Fld_Users_UsersActivityGroupLanguage_Title,
                Fld_Users_UsersActivityGroupLanguage_LanguageId = obj._Fld_Users_UsersActivityGroupLanguage_LanguageId,
               Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId = obj._Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId 
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createAlert(Alert obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Alerts
                          orderby a.Fld_Sitestyle_Alert_Id descending
                          select a.Fld_Sitestyle_Alert_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Alerts.InsertOnSubmit(new Tbl_Sitestyle_Alert
            {
                Fld_Sitestyle_Alert_Id = lastId + 1,
                Fld_Sitestyle_Alert_Title = obj._Fld_Sitestyle_Alert_Title,
                Fld_Sitestyle_Alert_Code = obj._Fld_Sitestyle_Alert_Code,
                Fld_Sitestyle_Alert_AlerttypeId = obj._Fld_Sitestyle_Alert_AlerttypeId
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createAlertLanguage(AlertLanguage obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_AlertLanguages
                          orderby a.Fld_Sitestyle_AlertLanguage_Id descending
                          select a.Fld_Sitestyle_AlertLanguage_Id).FirstOrDefault();

            db.Tbl_Sitestyle_AlertLanguages.InsertOnSubmit(new Tbl_Sitestyle_AlertLanguage
            {
                Fld_Sitestyle_AlertLanguage_Id = lastId + 1,
                Fld_Sitestyle_AlertLanguage_Title = obj._Fld_Sitestyle_AlertLanguage_Title,
                Fld_Sitestyle_AlertLanguage_Text = obj._Fld_Sitestyle_AlertLanguage_Text,
                Fld_Sitestyle_AlertLanguage_AlertId = obj._Fld_Sitestyle_AlertLanguage_AlertId,
                Fld_Sitestyle_AlertLanguage_LanguageId = obj._Fld_Sitestyle_AlertLanguage_LanguageId
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createAlertType(Alerttype obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Alerttypes
                          orderby a.Fld_Sitestyle_Alerttype_Id descending
                          select a.Fld_Sitestyle_Alerttype_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Alerttypes.InsertOnSubmit(new Tbl_Sitestyle_Alerttype
            {
                Fld_Sitestyle_Alerttype_Id = lastId + 1,
                Fld_Sitestyle_Alerttype_Name = obj._Fld_Sitestyle_Alerttype_Name,
                Fld_Sitestyle_Alerttype_Icon = obj._Fld_Sitestyle_Alerttype_Icon
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createCss(Css obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Csses
                          orderby a.Fld_Sitestyle_Css_Id descending
                          select a.Fld_Sitestyle_Css_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Csses.InsertOnSubmit(new Tbl_Sitestyle_Css
            {
                Fld_Sitestyle_Css_Id = lastId + 1,
                Fld_Sitestyle_Css_Name = obj._Fld_Sitestyle_Css_Name,
                Fld_Sitestyle_Css_LanguageId = obj._Fld_Sitestyle_Css_LanguageId
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createFont(Font obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Fonts
                          orderby a.Fld_Sitestyle_Font_Id descending
                          select a.Fld_Sitestyle_Font_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Fonts.InsertOnSubmit(new Tbl_Sitestyle_Font
            {
                Fld_Sitestyle_Font_Id = lastId + 1,
                Fld_Sitestyle_Font_Name = obj._Fld_Sitestyle_Font_Name,
                Fld_Sitestyle_Font_LanguageId = obj._Fld_Sitestyle_Font_LanguageId
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createIso1(Iso639_1 obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Iso639_1s
                          orderby a.Fld_Sitestyle_Iso639_1_Id descending
                          select a.Fld_Sitestyle_Iso639_1_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Iso639_1s.InsertOnSubmit(new Tbl_Sitestyle_Iso639_1
            {
                Fld_Sitestyle_Iso639_1_Id = lastId + 1,
                Fld_Sitestyle_Iso639_1_Code = obj._Fld_Sitestyle_Iso639_1_Code
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createIso2(Iso639_2 obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Iso639_2s
                          orderby a.Fld_Sitestyle_Iso639_2_Id descending
                          select a.Fld_Sitestyle_Iso639_2_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Iso639_2s.InsertOnSubmit(new Tbl_Sitestyle_Iso639_2
            {
                Fld_Sitestyle_Iso639_2_Id = lastId + 1,
                Fld_Sitestyle_Iso639_2_Code = obj._Fld_Sitestyle_Iso639_2_Code
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createIso3(Iso639_3 obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Iso639_3s
                          orderby a.Fld_Sitestyle_Iso639_3_Id descending
                          select a.Fld_Sitestyle_Iso639_3_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Iso639_3s.InsertOnSubmit(new Tbl_Sitestyle_Iso639_3
            {
                Fld_Sitestyle_Iso639_3_Id = lastId + 1,
                Fld_Sitestyle_Iso639_3_Code = obj._Fld_Sitestyle_Iso639_3_Code
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createLanguage(Language obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Languages
                          orderby a.Fld_Sitestyle_Language_Id descending
                          select a.Fld_Sitestyle_Language_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Languages.InsertOnSubmit(new Tbl_Sitestyle_Language
            {
                Fld_Sitestyle_Language_Id = lastId + 1,
                Fld_Sitestyle_Language_Direction = obj._Fld_Sitestyle_Language_Direction,
                Fld_Sitestyle_Language_Text = obj._Fld_Sitestyle_Language_Text,
                Fld_Sitestyle_Language_Iso639_1_Id = obj._Fld_Sitestyle_Language_Iso639_1_Id,
                Fld_Sitestyle_Language_Iso639_2_Id = obj._Fld_Sitestyle_Language_Iso639_2_Id,
                Fld_Sitestyle_Language_Iso639_3_Id = obj._Fld_Sitestyle_Language_Iso639_3_Id
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createMenuLanguage(MenuLanguage obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_MenuLanguages
                          orderby a.Fld_Sitestyle_MenuLanguage_Id descending
                          select a.Fld_Sitestyle_MenuLanguage_Id).FirstOrDefault();

            db.Tbl_Sitestyle_MenuLanguages.InsertOnSubmit(new Tbl_Sitestyle_MenuLanguage
            {
                Fld_Sitestyle_MenuLanguage_Id = lastId + 1,
                Fld_Sitestyle_MenuLanguage_Title = obj._Fld_Sitestyle_MenuLanguage_Title,
                Fld_Sitestyle_MenuLanguage_Tooltip = obj._Fld_Sitestyle_MenuLanguage_Tooltip,
                Fld_Sitestyle_MenuLanguage_LanguageId = obj._Fld_Sitestyle_MenuLanguage_LanguageId,
                Fld_Sitestyle_MenuLanguage_MenuId = obj._Fld_Sitestyle_MenuLanguage_MenuId
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createMenu(Menus obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Menus
                          orderby a.Fld_Sitestyle_Menu_Id descending
                          select a.Fld_Sitestyle_Menu_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Menus.InsertOnSubmit(new Tbl_Sitestyle_Menu
            {
                Fld_Sitestyle_Menu_Id = lastId + 1,
                Fld_Sitestyle_Menu_Text = obj._Fld_Sitestyle_Menu_Text,
                Fld_Sitestyle_Menu_Hotkey = obj._Fld_Sitestyle_Menu_Hotkey,
                Fld_Sitestyle_Menu_FontIcon = obj._Fld_Sitestyle_Menu_FontIcon,
                Fld_Sitestyle_Menu_ImageIcon = obj._Fld_Sitestyle_Menu_ImageIcon,
                Fld_Sitestyle_Menu_AccessId = obj._Fld_Sitestyle_Menu_AccessId
            });
            db.SubmitChanges();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static void createMetadata(Metadata obj)
        {
            DCDataContext db = new DCDataContext();

            int lastId = (from a in db.Tbl_Sitestyle_Metadatas
                          orderby a.Fld_Sitestyle_Metadata_Id descending
                          select a.Fld_Sitestyle_Metadata_Id).FirstOrDefault();

            db.Tbl_Sitestyle_Metadatas.InsertOnSubmit(new Tbl_Sitestyle_Metadata
            {
                Fld_Sitestyle_Metadata_Id = lastId + 1,
                Fld_Sitestyle_Metadata_Text = obj._Fld_Sitestyle_Metadata_Text,
                Fld_Sitestyle_Metadata_LanguageId = obj._Fld_Sitestyle_Metadata_LanguageId
            });
            db.SubmitChanges();
        }




    }
}