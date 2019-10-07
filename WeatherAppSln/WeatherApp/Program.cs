using System;
using System.Threading.Tasks;
using WeatherApp;
using WeatherLibrary;
using WeatherLibrary.Models;

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            WeatherGenerator weatherGenerator = new WeatherGenerator();
            WeatherInformation weatherInformation =  await WeatherGenerator.GetWeatherfaceAsync();


            Console.SetCursorPosition(3, 2);   
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Temperature: " + weatherInformation.Temperature);

            Console.SetCursorPosition(10, 5);
            Console.Write("Humidity: " + weatherInformation.Humidity);

            Console.SetCursorPosition(10, 7);
            Console.Write("Weather: " + weatherInformation.Weather);


            /*var  splitting =weatherString.Split(' ');
            foreach (var split in splitting)
            {
                var splitting1 = split.Split(':');

                foreach (var split1 in splitting1)

                    Console.WriteLine(split1);
                   // Console.WriteLine(split);
            } 
            */
        }
    }
}
