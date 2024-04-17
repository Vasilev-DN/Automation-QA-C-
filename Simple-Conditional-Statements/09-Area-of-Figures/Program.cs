﻿string figureType = Console.ReadLine();

if (figureType == "square")
{
    double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine($"{area:F2}");
}
else if (figureType == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double lenght = double.Parse(Console.ReadLine());
    double area = width * lenght;
    Console.WriteLine($"{area:F2}");
}
else if (figureType == "circle")
{ 
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * radius * radius;
    Console.WriteLine($"{area:F2}");
}
