namespace Weather.AccuWeather.Models
{
    public class WeatherResult
    {
        public string Location { get; private set; }
        public double TemperatureFahrenheit { get; private set; }
        public double WindSpeedMph { get; private set; }

        public WeatherResult(string location, double temperatureFahrenheit, double windSpeedMph)
        {
            Location = location;
            TemperatureFahrenheit = temperatureFahrenheit;
            WindSpeedMph = windSpeedMph;
        }
    }
}
