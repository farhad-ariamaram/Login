using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace NewTest
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        DCDataContext db;

        public WebService()
        {
            db = new DCDataContext();
        }


        //Edit a Row of Table
        [WebMethod]
        public void EditCss(Tbl_Sitestyle_Css obj)
        {
            var result = (from a in db.Tbl_Sitestyle_Csses
                          where a.Fld_Sitestyle_Css_Id == obj.Fld_Sitestyle_Css_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Css_LanguageId = obj.Fld_Sitestyle_Css_LanguageId;
            result.Fld_Sitestyle_Css_Name = obj.Fld_Sitestyle_Css_Name;
            db.SubmitChanges();
        }

        [WebMethod]
        public void EditFont(Tbl_Sitestyle_Font obj)
        {
            var result = (from a in db.Tbl_Sitestyle_Fonts
                          where a.Fld_Sitestyle_Font_Id == obj.Fld_Sitestyle_Font_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Font_LanguageId = obj.Fld_Sitestyle_Font_LanguageId;
            result.Fld_Sitestyle_Font_Name = obj.Fld_Sitestyle_Font_Name;
            db.SubmitChanges();
        }

        [WebMethod]
        public void EditMetadata(Tbl_Sitestyle_Metadata obj)
        {
            var result = (from a in db.Tbl_Sitestyle_Metadatas
                          where a.Fld_Sitestyle_Metadata_Id == obj.Fld_Sitestyle_Metadata_Id
                          select a).SingleOrDefault();
            result.Fld_Sitestyle_Metadata_Text = obj.Fld_Sitestyle_Metadata_Text;
            result.Fld_Sitestyle_Metadata_LanguageId = obj.Fld_Sitestyle_Metadata_LanguageId;
            db.SubmitChanges();
        }




        //Get All Rows of Tables 
        [WebMethod]
        public List<Tbl_Sitestyle_Menu> GetMenus()
        {
            var query = (from a in db.Tbl_Sitestyle_Menus
                         select a).ToList();
            return query;
        }

        [WebMethod]
        public List<Tbl_Sitestyle_Language> GetLanguages()
        {
            var query = (from a in db.Tbl_Sitestyle_Languages
                         select a).ToList();
            return query;
        }

        [WebMethod]
        public List<Tbl_Sitestyle_Alerttype> GetAlertTypes()
        {
            var query = (from a in db.Tbl_Sitestyle_Alerttypes
                         select a).ToList();
            return query;
        }

        [WebMethod]
        public List<Tbl_Sitestyle_Alert> GetAlerts()
        {
            var query = (from a in db.Tbl_Sitestyle_Alerts
                         select a).ToList();
            return query;
        }

        [WebMethod]
        public List<Tbl_Sitestyle_Css> GetCsses()
        {
            var query = (from a in db.Tbl_Sitestyle_Csses
                         select a).ToList();
            return query;
        }

        [WebMethod]
        public List<Tbl_Sitestyle_Font> GetFonts()
        {
            var query = (from a in db.Tbl_Sitestyle_Fonts
                         select a).ToList();
            return query;
        }

        [WebMethod]
        public List<Tbl_Sitestyle_Metadata> GetMetadatas()
        {
            var query = (from a in db.Tbl_Sitestyle_Metadatas
                         select a).ToList();
            return query;
        }







        //Add Row to Table
        [WebMethod]
        public void AddLanguage(Tbl_Sitestyle_Language obj)
        {
            db.Tbl_Sitestyle_Languages.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        [WebMethod]
        public void AddMenu(Tbl_Sitestyle_Menu obj)
        {
            db.Tbl_Sitestyle_Menus.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        [WebMethod]
        public void AddMenuLanguage(Tbl_Sitestyle_MenuLanguage obj)
        {
            db.Tbl_Sitestyle_MenuLanguages.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        [WebMethod]
        public void AddAlertType(Tbl_Sitestyle_Alerttype obj)
        {
            db.Tbl_Sitestyle_Alerttypes.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        [WebMethod]
        public void AddAlert(Tbl_Sitestyle_Alert obj)
        {
            db.Tbl_Sitestyle_Alerts.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        [WebMethod]
        public void AddAlertLanguage(Tbl_Sitestyle_AlertLanguage obj)
        {
            db.Tbl_Sitestyle_AlertLanguages.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        [WebMethod]
        public void AddCss(Tbl_Sitestyle_Css obj)
        {
            db.Tbl_Sitestyle_Csses.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        [WebMethod]
        public void AddMetadata(Tbl_Sitestyle_Metadata obj)
        {
            db.Tbl_Sitestyle_Metadatas.InsertOnSubmit(obj);
            db.SubmitChanges();
        }

        [WebMethod]
        public void AddFont(Tbl_Sitestyle_Font obj)
        {
            db.Tbl_Sitestyle_Fonts.InsertOnSubmit(obj);
            db.SubmitChanges();
        }





        //Get Last ID Of Table
        [WebMethod]
        public int GetLanguageLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Languages
                          orderby a.Fld_Sitestyle_Language_Id descending
                          select a.Fld_Sitestyle_Language_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetMenuLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Menus
                          orderby a.Fld_Sitestyle_Menu_Id descending
                          select a.Fld_Sitestyle_Menu_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetIso1LastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Iso639_1s
                          orderby a.Fld_Sitestyle_Iso639_1_Id descending
                          select a.Fld_Sitestyle_Iso639_1_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetIso2LastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Iso639_2s
                          orderby a.Fld_Sitestyle_Iso639_2_Id descending
                          select a.Fld_Sitestyle_Iso639_2_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetIso3LastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Iso639_3s
                          orderby a.Fld_Sitestyle_Iso639_3_Id descending
                          select a.Fld_Sitestyle_Iso639_3_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetMenuLanguageLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_MenuLanguages
                          orderby a.Fld_Sitestyle_MenuLanguage_Id descending
                          select a.Fld_Sitestyle_MenuLanguage_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetAlertTypeLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Alerttypes
                          orderby a.Fld_Sitestyle_Alerttype_Id descending
                          select a.Fld_Sitestyle_Alerttype_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetAlertLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Alerts
                          orderby a.Fld_Sitestyle_Alert_Id descending
                          select a.Fld_Sitestyle_Alert_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetAlertLanguageLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_AlertLanguages
                          orderby a.Fld_Sitestyle_AlertLanguage_Id descending
                          select a.Fld_Sitestyle_AlertLanguage_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetCssLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Csses
                          orderby a.Fld_Sitestyle_Css_Id descending
                          select a.Fld_Sitestyle_Css_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetMetadataLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Metadatas
                          orderby a.Fld_Sitestyle_Metadata_Id descending
                          select a.Fld_Sitestyle_Metadata_Id).FirstOrDefault();
            return lastId;
        }

        [WebMethod]
        public int GetFontLastId()
        {
            int lastId = (from a in db.Tbl_Sitestyle_Fonts
                          orderby a.Fld_Sitestyle_Font_Id descending
                          select a.Fld_Sitestyle_Font_Id).FirstOrDefault();
            return lastId;
        }

    }
}


