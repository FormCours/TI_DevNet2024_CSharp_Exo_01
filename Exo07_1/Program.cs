using Exo07_1.Models;

Celsius c1;
c1.Temperature = 23.5;
Console.WriteLine($"Temp (c1) : {c1.Temperature} °C");

Fahrenheit f1 = c1.ToFahrenheit();
Console.WriteLine($"Temp (f1) : {f1.Temperature} °F");

Celsius c2 = f1.ToCelsius();
Console.WriteLine($"Temp (c2) : {c2.Temperature} °C");