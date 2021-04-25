
namespace NewTest.DTOs
{
    public class Alert
    {
        public int _Fld_Sitestyle_Alert_Id;

        public string _Fld_Sitestyle_Alert_Title;

        public string _Fld_Sitestyle_Alert_Code;

        public int _Fld_Sitestyle_Alert_AlerttypeId;
    }

    public class RAlert
    {
        public int _Fld_Sitestyle_Alert_Id;

        public string _Fld_Sitestyle_Alert_Title;

        public string _Fld_Sitestyle_Alert_Code;

        public string _Fld_Sitestyle_Alert_Alerttype;
    }

    public class DDAlert
    {
        public int _Fld_Sitestyle_Alert_Id;

        public string _Fld_Sitestyle_Alert_Title;
    }

    public class AlertLanguage
    {
        public int _Fld_Sitestyle_AlertLanguage_Id;

        public string _Fld_Sitestyle_AlertLanguage_Text;

        public string _Fld_Sitestyle_AlertLanguage_Title;

        public int _Fld_Sitestyle_AlertLanguage_AlertId;

        public int _Fld_Sitestyle_AlertLanguage_LanguageId;
    }

    public class RAlertLanguage
    {
        public int _Fld_Sitestyle_AlertLanguage_Id;

        public string _Fld_Sitestyle_AlertLanguage_Text;

        public string _Fld_Sitestyle_AlertLanguage_Title;

        public string _Fld_Sitestyle_AlertLanguage_Alert;

        public string _Fld_Sitestyle_AlertLanguage_Language;
    }

    public class Alerttype
    {
        public int _Fld_Sitestyle_Alerttype_Id;

        public string _Fld_Sitestyle_Alerttype_Name;

        public string _Fld_Sitestyle_Alerttype_Icon;
    }

    public class DDAlerttype
    {
        public int _Fld_Sitestyle_Alerttype_Id;

        public string _Fld_Sitestyle_Alerttype_Name;
    }

    public class Css
    {
        public int _Fld_Sitestyle_Css_Id;

        public string _Fld_Sitestyle_Css_Name;

        public int _Fld_Sitestyle_Css_LanguageId;
    }

    public class RCss
    {
        public int _Fld_Sitestyle_Css_Id;

        public string _Fld_Sitestyle_Css_Name;

        public string _Fld_Sitestyle_Css_Language;
    }

    public class Font
    {
        public int _Fld_Sitestyle_Font_Id;

        public string _Fld_Sitestyle_Font_Name;

        public int _Fld_Sitestyle_Font_LanguageId;
    }

    public class RFont
    {
        public int _Fld_Sitestyle_Font_Id;

        public string _Fld_Sitestyle_Font_Name;

        public string _Fld_Sitestyle_Font_Language;
    }

    public class Iso639_1
    {
        public int _Fld_Sitestyle_Iso639_1_Id;

        public string _Fld_Sitestyle_Iso639_1_Code;
    }

    public class Iso639_2
    {
        public int _Fld_Sitestyle_Iso639_2_Id;

        public string _Fld_Sitestyle_Iso639_2_Code;
    }

    public class Iso639_3
    {
        public int _Fld_Sitestyle_Iso639_3_Id;

        public string _Fld_Sitestyle_Iso639_3_Code;
    }

    public class Language
    {
        public int _Fld_Sitestyle_Language_Id;

        public string _Fld_Sitestyle_Language_Text;

        public string _Fld_Sitestyle_Language_Direction;

        public int _Fld_Sitestyle_Language_Iso639_1_Id;

        public int _Fld_Sitestyle_Language_Iso639_2_Id;

        public int _Fld_Sitestyle_Language_Iso639_3_Id;
    }

    public class RLanguage
    {
        public int _Fld_Sitestyle_Language_Id;

        public string _Fld_Sitestyle_Language_Text;

        public string _Fld_Sitestyle_Language_Direction;

        public string _Fld_Sitestyle_Language_Iso639_1;

        public string _Fld_Sitestyle_Language_Iso639_2;

        public string _Fld_Sitestyle_Language_Iso639_3;
    }

    public class DDLanguage
    {
        public int _Fld_Sitestyle_Language_Id;

        public string _Fld_Sitestyle_Language_Text;
    }

    public class Menus
    {
        public int _Fld_Sitestyle_Menu_Id;

        public string _Fld_Sitestyle_Menu_Text;

        public string _Fld_Sitestyle_Menu_Hotkey;

        public string _Fld_Sitestyle_Menu_FontIcon;

        public string _Fld_Sitestyle_Menu_ImageIcon;

        public int _Fld_Sitestyle_Menu_AccessId;
    }

    public class DDMenu
    {
        public int _Fld_Sitestyle_Menu_Id;

        public string _Fld_Sitestyle_Menu_Text;
    }

    public class MenuLanguage
    {
        public int _Fld_Sitestyle_MenuLanguage_Id;

        public string _Fld_Sitestyle_MenuLanguage_Title;

        public string _Fld_Sitestyle_MenuLanguage_Tooltip;

        public int _Fld_Sitestyle_MenuLanguage_MenuId;

        public int _Fld_Sitestyle_MenuLanguage_LanguageId;
    }

    public class RMenuLanguage
    {
        public int _Fld_Sitestyle_MenuLanguage_Id;

        public string _Fld_Sitestyle_MenuLanguage_Title;

        public string _Fld_Sitestyle_MenuLanguage_Tooltip;

        public string _Fld_Sitestyle_MenuLanguage_Menu;

        public string _Fld_Sitestyle_MenuLanguage_Language;
    }

    public class Metadata
    {
        public int _Fld_Sitestyle_Metadata_Id;

        public string _Fld_Sitestyle_Metadata_Text;

        public int _Fld_Sitestyle_Metadata_LanguageId;
    }

    public class RMetadata
    {
        public int _Fld_Sitestyle_Metadata_Id;

        public string _Fld_Sitestyle_Metadata_Text;

        public string _Fld_Sitestyle_Metadata_Language;
    }

    public class UserActivityGroup
    {
        public int _Fld_Users_UsersActivityGroup_Id;

        public string _Fld_Users_UsersActivityGroup_Title;
    }

    public class DDUserActivityGroup
    {
        public int _Fld_Users_UsersActivityGroup_Id;

        public string _Fld_Users_UsersActivityGroup_Title;
    }

    public class UserActivityGroupLanguage
    {
        public int _Fld_Users_UsersActivityGroupLanguage_Id;

        public string _Fld_Users_UsersActivityGroupLanguage_Title;

        public int _Fld_Users_UsersActivityGroupLanguage_UsersActivityGroupId;

        public int _Fld_Users_UsersActivityGroupLanguage_LanguageId;
    }

    public class RUserActivityGroupLanguage
    {
        public int _Fld_Users_UsersActivityGroupLanguage_Id;

        public string _Fld_Users_UsersActivityGroupLanguage_Title;

        public string _Fld_Users_UsersActivityGroupLanguage_UsersActivityGroup;

        public string _Fld_Users_UsersActivityGroupLanguage_Language;
    }

}









