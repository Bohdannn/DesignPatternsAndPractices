using WeatherMonitoringApp_Observer.Abstract;
using static System.Console;

namespace WeatherMonitoringApp_Observer.Concrete;

internal class ForecastDisplay : IObserver, IDisplayElement
{
    private float _currentPressure = 29.92f;
    private float _lastPressure;

    // "In the future we may want to un-register ourselves as an observer
    // and it would be handy to already have a reference to the subject"
    private readonly WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _lastPressure = _currentPressure;
        _currentPressure = _weatherData.GetPressure();

        // "In this simple example it made sense to call Display() when the
        // values changed. However, there are much better ways to
        // design the way the data gets displayed"
        Display();
    }

    public void Display()
    {
        if (_currentPressure > _lastPressure)
        {
            WriteLine("Forecast: Improving weather on the way!");
        }
        else if (_currentPressure == _lastPressure)
        {
            WriteLine("Forecast: More of the same");
        }
        else if (_currentPressure < _lastPressure)
        {
            WriteLine("Forecast: Watch out for cooler, rainy weather");
        }
    }
}