using WeatherMonitoringApp_Observer.Abstract;
using static System.Console;

namespace WeatherMonitoringApp_Observer.Concrete;

internal class HeatIndexDisplay : IObserver, IDisplayElement
{
    private float _heatIndex;
    private readonly WeatherData _weatherData;

    public HeatIndexDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _heatIndex = ComputeHeatIndex(_weatherData.GetTemperature(),
            _weatherData.GetHumidity());

        Display();
    }

    public void Display() => WriteLine($"The heat index is: {_heatIndex}");

    /// <summary>
    /// Calculates a heat index.
    /// </summary>
    /// <param name="t">Temperature</param>
    /// <param name="rh">Humidity</param>
    /// <returns>Heat index</returns>
    private static float ComputeHeatIndex(float t, float rh)
    {
        return (float)(16.923 + 0.185212 * t + 5.37941 * rh - 0.100254 * t * rh +
            0.00941695 * (t * t) + 0.00728898 * (rh * rh) +
            0.000345372 * (t * t * rh) - 0.000814971 * (t * rh * rh) +
            0.0000102102 * (t * t * rh * rh) - 0.000038646 * (t * t * t) +
            0.0000291583 * (rh * rh * rh) + 0.00000142721 * (t * t * t * rh) +
            0.000000197483 * (t * rh * rh * rh) - 0.0000000218429 * (t * t * t * rh * rh) +
            0.000000000843296 * (t * t * rh * rh * rh) -
            0.0000000000481975 * (t * t * t * rh * rh * rh));
    }
}