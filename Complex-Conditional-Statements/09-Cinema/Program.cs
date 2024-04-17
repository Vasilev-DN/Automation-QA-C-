string movieType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

double totalAmount = 0;

if (movieType == "Normal")
{
    totalAmount = rows * seats * 7.50;
}
else if (movieType == "Premiere")
{
    totalAmount = rows * seats * 12.00;
}
else if (movieType == "Discount")
{
    totalAmount = rows * seats * 5.00;
}

Console.WriteLine($"{totalAmount:F2}");