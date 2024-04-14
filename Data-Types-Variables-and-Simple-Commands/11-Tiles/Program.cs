double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeight * 1.1;
double tileArea = tileWidth * tileHeight;
double neededTiles = bathroomArea / tileArea;

Console.WriteLine($"{neededTiles:F0}");