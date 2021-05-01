using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            using (WebClient client = new WebClient())
            {
                Console.Write("Введите название вашего города(на английском):");
                string cityname = Console.ReadLine();
                string response = client.DownloadString($"https://api.openweathermap.org/data/2.5/weather?q={cityname}&units=metric&appid=5933b7ccc81eecf5c24f9dc61c1826b9");
                Settings settings = JsonConvert.DeserializeObject<Settings>(response);
                Console.WriteLine( settings.Main.Temp);
                Console.ReadLine();
                Console.ReadLine();
            }      
        }
    }
}
