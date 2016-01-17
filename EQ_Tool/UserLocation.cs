using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace EQ_Tool
{
    // Got the infos from here: www.codeproject.com/Tips/397574/Use-Csharp-to-get-JSON-Data-from-the-Web-and-Map-i
    public class UserLocation
    {
            public string ip { get; set; }
            public string hostname { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public string loc { get; set; }
            public string org { get; set; }
            public string postal { get; set; }
   

        public T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }

        //Gets the latitude and longitude of your current location
        // #0 == lat
        // #1 == long
        public double[] getLatAndLong()
        {
            string[] userlocationLatLong_string = loc.Split(',');
            double[] userlocationLatLong_double = {
                                                    Convert.ToDouble(userlocationLatLong_string[0], System.Globalization.CultureInfo.InvariantCulture),
                                                    Convert.ToDouble(userlocationLatLong_string[1], System.Globalization.CultureInfo.InvariantCulture)
                                                  };

            return userlocationLatLong_double;
        }
    }
}
