using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace PhoneBook
{
    static class Base
    {
        #region Variables & Properties

        public static string path = string.Concat(Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar.ToString());
        public static string dBpw = "thDUjvGkoukRuIROh9gs";
        public static string fileDb = "contactlist.tel";
        public static string cnnStr;


        public static string hashKey = "§";

        #endregion

        #region Messages & Errors

        public const string msgTitle = "My Phone Book System";
        public const string msgErrTitle = "خطاي زمان اجرا";

        #endregion

        #region Messages & Errors


        #endregion

        static Base()
        {
            fileDb = string.Concat(path, fileDb);
            cnnStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw);
        }

        #region

        public static string GetPersianDate()
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            DateTime dt = DateTime.Now;

            //{0} = Year
            //{1} = Month
            //{2} = Day
            return String.Format("{0}/{1}/{2}", pc.GetYear(dt), pc.GetMonth(dt), pc.GetDayOfMonth(dt));
        }

        #endregion
    }
}
