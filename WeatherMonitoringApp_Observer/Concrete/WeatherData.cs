using WeatherMonitoringApp_Observer.Abstract;

namespace WeatherMonitoringApp_Observer.Concrete;

internal class WeatherData : ISubject
{
    private readonly IList<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public WeatherData() => _observers = new List<IObserver>();

    public float GetTemperature() => _temperature;

    public float GetHumidity() => _humidity;

    public float GetPressure() => _pressure;

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);

    public void UnregisterObserver(IObserver observer) => _observers.Remove(observer);

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public void MeasurementsChanged() => NotifyObservers();

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;

        MeasurementsChanged();
    }
}