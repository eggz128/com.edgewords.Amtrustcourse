using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace com.edgewords.Amtrustcourse.Helpers
{
    public static class Globals
    {
        public static int GLOBAL_TIMEOUT
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["GlblTimeout"]);  }
        }

        public static string BASE_URL
        {
            get { return ConfigurationManager.AppSettings["BaseAddress"]; }
        }

    }
}
