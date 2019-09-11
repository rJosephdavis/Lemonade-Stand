using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lemonadeStandtest
{
    public class Day
    {
        public Weather weather;
        public void Weather()
        {

            weather = new Weather();
            string actualWeatherForTheDay = weather.weather;
            weather.temp
            weather.conditions
            weather. forecast 

            

/*            List<string> Weather = new List<string>();
            Weather.Add("WeatherConditions");
            Weather.Add("Temperture");
            Weather.Add("Forecast");



            foreach (string weather in weather.WeatherConditions)
            {
                Console.WriteLine(weather);
                // generate random number between 0 and weather.WeatherConditions.Count
                Random rnd = new Random();
                int WeatherCondition = rnd.Next(4);
                //Console.WriteLine("Random:" + random.Next(0, 4));

                // select the index from the list that is the random number to get the random weather
            }*/
        }
    }
}