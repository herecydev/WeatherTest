namespace Weather.Bbc.Models
{
    public class WeatherResult
    {
        public string Location { get; private set; }
        public double TemperatureCelsius { get; private set; }
        public double WindSpeedKph { get; private set; }

        public WeatherResult(string location, double temperatureCelsius, double windSpeedKph)
        {
            Location = location;
            TemperatureCelsius = temperatureCelsius;
            WindSpeedKph = windSpeedKph;
        }
    }
}
