using Adapter;

FahrenheitSensor fahrenheitSensor = new FahrenheitSensor();
ITemperatureService temperatureService = new TemperatureAdapter(fahrenheitSensor);

Console.WriteLine("FahrenheitSensor interface is incompatible with the client");
Console.WriteLine("But with adapter client can call it's method");

Console.WriteLine($"Temperature: {temperatureService.GetTemperatureCelsius()} °C");