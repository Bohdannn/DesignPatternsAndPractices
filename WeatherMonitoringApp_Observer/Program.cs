using WeatherMonitoringApp_Observer.Concrete;

var weatherData = new WeatherData();

new CurrentConditionsDisplay(weatherData);
new StatisticsDisplay(weatherData);
new ForecastDisplay(weatherData);
new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);