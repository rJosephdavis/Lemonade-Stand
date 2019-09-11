using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lemonadeStandtest
{
    public class Weather
    {
        public List<string> WeatherConditions;
        List<int> WeatherTemperature;
        public int foreCastTempurature;
        public int actualTemp;
        List<int> WeatherForecast;

        public string weather;
        public int temp;
        public int forecast;
        public Weather()
        {
            Random random = new Random();
            WeatherConditions = new List<string>() { "Cloudy", "Sunny","Rainy", "Humid", "Clear" };
            WeatherTemperature = new List<int>() {75, 89, 100, 53, 60 };
            WeatherForecast = new List<int>() {79, 80, 90, 48, 68 };
            GenerateWeather(random);

        }

        public void GenerateWeather(Random random)
        {
            weather = WeatherConditions[random.Next(4)];
            temp = WeatherTemperature[random.Next(4)];
            forecast = WeatherForecast[random.Next(4)];
        }
    }
}
        