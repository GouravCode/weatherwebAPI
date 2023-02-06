using System;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace pwcTask
{
    class Program 
    {
        static void Main(string[] args)
        {
            decimal latitude = 0.0M;
            decimal longitude = 0.0M;
            if (args.Length == 1)
            {

                string text = File.ReadAllText(@"./cities.json");
                cityClass[] citiesObject = JsonConvert.DeserializeObject<cityClass[]>(text);
                for (int i = 0; i < citiesObject.Length; i++)
                {
                    if (citiesObject[i].city == args[0])
                    {
                        latitude = Convert.ToDecimal(citiesObject[i].lat);
                        longitude = Convert.ToDecimal(citiesObject[i].lng);
                        break;
                    }
                }
                using (var client = new WebClient())
                {
                    client.Headers.Add("Content-Type:application/json");
                    client.Headers.Add("Accept:application/json");
                    var result = client.DownloadString("https://api.open-meteo.com/v1/forecast?latitude="+latitude+"&longitude="+longitude+"&current_weather=true");
                    Rootobject1 crw = JsonConvert.DeserializeObject<Rootobject1>(result);
                    Current_Weather crw_details = new Current_Weather();
                    crw_details = crw.current_weather;
                    Console.WriteLine("Temperature : "+crw_details.temperature + 
                        "\nTime : " + crw_details.time+
                        "\nWeathe Code : " + crw_details.weathercode+ 
                        "\nWind Direction : " + crw_details.winddirection+
                        "\nWind Speed: " + crw_details.windspeed);
                }
                Console.ReadLine();
            }
            else
                Console.WriteLine("Please Enter valid City Name.");

            
        }
    }
}
