using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_Automizer
{
    class Constants
    {
        private static String API_URL = "https://api.moroz.cc/orderautomator/";

        public static String getApiUrl()
        {
            return API_URL;
        }
    }
}
