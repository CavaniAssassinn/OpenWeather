using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using WeatherLibrary;
using WeatherLibrary.Models;

namespace WeatherApp
{
    public class WeatherGenerator
    {
        public static async Task<WeatherInformation> GetWeatherfaceAsync()
        {
            HttpClient httpClient = new HttpClient();
            string wap = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=519a0f95f837140610507814c492055f&units=metric");

           // WeatherGetter weatherGetter = new WeatherGetter();
            WeatherGetter weather =  JsonConvert.DeserializeObject<WeatherGetter>(wap);
            string returnString = string.Empty;
           // string returnString1 = string.Empty;
            //string returnString2= string.Empty;
            //    string returnString3 = string.Empty;
            int index = 0;

            var weatherInformation = new WeatherInformation();

            weatherInformation.Temperature = weather.main.temp;
            weatherInformation.Humidity = weather.main.humidity;



            while (index < weather.weather.Count)
            {
                weatherInformation.Weather = weather.weather[index].description;
                index++;
            }

            /*
            while (index < weather.weather.Count) 
            {

                returnString = "description:" + weather.weather[index].description + " ";
                //returnString += weather.weather[index].icon + "";
                returnString += "main:" + weather.weather[index].main + " ";
                returnString += "wind speed:" + weather.wind.speed + " ";
                returnString += "wind degrees:" + weather.wind.deg + " ";
                returnString += "Clouds:" + weather.clouds.all + " ";
                //returnString += ":" + weather.cod + " ";
                //returnString += ":" + weather.coord + " ";
                //returnString += ":" + weather.dt + " ";
                //returnString += ":" + weather.id + " ";
                returnString += "humudity:" + weather.main.humidity + " ";
                returnString += "pressure:" + weather.main.pressure + " ";
                returnString += "tempreture:" + weather.main.temp + " ";
                returnString += "tempreture max:" + weather.main.temp_max + " ";
                returnString += "tempreture min:" + weather.main.temp_min + " ";
                returnString += "city:" + weather.name + " ";
                returnString += "country:" + weather.sys.country + " ";
                //returnString += ":" + weather.sys.id + " ";
                //returnString += "message:" + weather.sys.message + " ";
                //returnString += "sunrise:" + weather.sys.sunrise + " ";
                //returnString += "sunset:" + weather.sys.sunset + " ";
                //returnString += "type:" + weather.sys.type + " ";
                //returnString += "timezone:" + weather.timezone + " ";
               // returnString += "visibility:" + weather.visibility + " ";




            //returnString3 = weather.weather[index];

            index++;
        }
*/
            return weatherInformation;
            
        }
    }
}
