using WeatherMonitoringApp_Observer.Abstract;
using static System.Console;

namespace WeatherMonitoringApp_Observer.Concrete;

internal class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;

    // "In the future we may want to un-register ourselves as an observer
    // and it would be handy to already have a reference to the subject"
    private readonly WeatherData _weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _temperature = _weatherData.GetTemperature();
        _humidity = _weatherData.GetHumidity();

        // "In this simple example it made sense to call display() when the
        // values changed. However, there are much better ways to
        // design the way the data gets displayed"
        Display();
    }

    public void Display() => WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
}