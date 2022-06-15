namespace WeatherMonitoringApp_Observer.Abstract;

internal interface ISubject
{
    void RegisterObserver(IObserver observer);

    void UnregisterObserver(IObserver observer);

    void NotifyObservers();
}