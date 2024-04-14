int nylonInM2 = int.Parse(Console.ReadLine());
int paintInliters = int.Parse(Console.ReadLine());
int thinnerInliters = int.Parse(Console.ReadLine());
int neededHoursforWork = int.Parse(Console.ReadLine());

double totalNyloncost = (nylonInM2 + 2) * 1.50;
double totalPaintcost = (paintInliters * 1.1) * 14.50;
double totalThinnercost = thinnerInliters * 5.00;
double bagsPrice = 0.4;
double totalMaterialCost = totalNyloncost + totalPaintcost + totalThinnercost + bagsPrice;
double craftsmenCost = 0.3 * totalMaterialCost * neededHoursforWork;
double totalCost = totalMaterialCost + craftsmenCost;

Console.WriteLine($"{totalCost}");




