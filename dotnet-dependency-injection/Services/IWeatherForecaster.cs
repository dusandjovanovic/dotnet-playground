namespace dotnet_dependency_injection.Services
{
    public interface IWeatherForecaster
    {
        WeatherResult GetCurrentWeather();
    }
}