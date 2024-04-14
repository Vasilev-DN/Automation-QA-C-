double temperatureIncelsius = double.Parse(Console.ReadLine());

double temperatureInfahrenheit = temperatureIncelsius * 1.8 + 32;

Console.WriteLine($"{temperatureInfahrenheit:F2}");
