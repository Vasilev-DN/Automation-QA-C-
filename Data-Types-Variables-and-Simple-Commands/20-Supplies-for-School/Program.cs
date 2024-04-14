int packagesOfpens = int.Parse(Console.ReadLine());
int packetsOfmarkers = int.Parse(Console.ReadLine());
int litersOfboardcleaner = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

double priceFormaterials = packagesOfpens * 5.80 + packetsOfmarkers * 7.20 + litersOfboardcleaner * 1.20;
double discount = (priceFormaterials * discountPercentage) / 100;
double totalCost = priceFormaterials - discount;


Console.WriteLine($"{totalCost:F2}");

