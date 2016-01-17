using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EQ_Tool
{
    /*
    *
    * A new Type called EQ_ListData
    *
    */
    public class EQ_ListData
    {
        public string description {get; set; }
        public DateTime date { get; set; }
        public string magnitude { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }

        public string formatedDescription()
        {
            // Format of description is usually like: SE 100km of Tokoy, Japan
            // I want to get rid of the SE 100km and the country and only show the town info 
            if (description.Contains("of"))
            {
                string[] formatedDescription = Regex.Split(description, "of");
                return formatedDescription[1].Remove(formatedDescription[1].LastIndexOf(',')).Trim();
            }

            return description.Remove(description.LastIndexOf(','));
            
        }


    }
}
