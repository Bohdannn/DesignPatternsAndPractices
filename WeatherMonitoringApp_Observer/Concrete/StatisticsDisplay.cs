using WeatherMonitoringApp_Observer.Abstract;
using static System.Console;

namespace WeatherMonitoringApp_Observer.Concrete;

internal class StatisticsDisplay : IObserver, IDisplayElement
{
    private float _maxTemperature;
    private float _minTemperature = 200f;
    private float _temperatureSum;
    private int _readingsCount;

    // "In the future we may want to un-register ourselves as an observer
    // and it would be handy to already have a reference to the subject"
    private readonly WeatherData _weatherData;

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        var temperature = _weatherData.GetTemperature();

        _temperatureSum += temperature;
        _readingsCount++;

        if (temperature > _maxTemperature)
        {
            _maxTemperature = temperature;
        }

        if (temperature < _minTemperature)
        {
            _minTemperature = temperature;
        }

        // "In this simple example it made sense to call display() when the
        // values changed. However, there are much better ways to
        // design the way the data gets displayed"
        Display();
    }

    public void Display() => WriteLine("Avg/Max/Min temperature = " +
            $"{_temperatureSum / _readingsCount}/{_maxTemperature}/{_minTemperature}");
}