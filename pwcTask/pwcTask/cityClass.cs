using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwcTask
{

    public class Rootobject
    {
        public cityClass[] Property1 { get; set; }
    }

    public class cityClass
    {
        public string city { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string country { get; set; }
        public string iso2 { get; set; }
        public string admin_name { get; set; }
        public string capital { get; set; }
        public string population { get; set; }
        public string population_proper { get; set; }
    }

    public class Rootobject1
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Weather current_weather { get; set; }
    }

    public class Current_Weather
    {
        public float temperature { get; set; }
        public float windspeed { get; set; }
        public float winddirection { get; set; }
        public int weathercode { get; set; }
        public string time { get; set; }
    }


}
