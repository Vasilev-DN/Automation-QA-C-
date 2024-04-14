double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double tomatoesCost = tomatoPrice * tomatoQuantity;
double cucumberCost = cucumberPrice * cucumberQuantity;
double totalCost =tomatoesCost + cucumberCost;

Console.WriteLine($"{totalCost:F2}");