using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather_forecast
{
    public static class Weather
    {
       

        public static string WhatsUpWithTheWeatherToday(string t)
        {
            int ct = Convert.ToInt32(t.Trim(new char[] { '+', 'C' }));
            
            switch (ct)
            {
                case (>= -50) when ct <= -1:
                    return("It`s super cold today. Be sure you will dress well!");

                case (>= 0) when ct <= 10:
                    return ("It`s windy outside, but we are sure you will enjoy your day");

                case (>= 11) when ct <= 30:
                    return ("It`s time for outdoor walking");

                case (>= 31) when ct <= 40:
                    return ("It`s so hot outside");

                case (>= 41) when ct <= 50:
                    return ("Welcome to hell!");

                default:
                    return ("Please re-check result in 5 minutes");
            }
        }
    }
}
