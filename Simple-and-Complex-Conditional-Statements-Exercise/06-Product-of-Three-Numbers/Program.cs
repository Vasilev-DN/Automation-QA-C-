double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());
double number3 = double.Parse(Console.ReadLine());

double product = number1 * number2 * number3;

if (product > 0)
{
    Console.WriteLine("positive");
}
else if (product < 0)
{
    Console.WriteLine("negative");
}
else if (product == 0)
{
    Console.WriteLine("zero");
}