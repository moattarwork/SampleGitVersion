using System;

namespace sampleapi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 45 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
