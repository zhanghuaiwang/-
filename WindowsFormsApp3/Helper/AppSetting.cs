using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace WindowsFormsApp3.Helper
{
    public class AppSetting
    {
        public static string con = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ToString();
    }
}
