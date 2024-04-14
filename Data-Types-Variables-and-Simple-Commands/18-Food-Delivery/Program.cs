int numberOfchickenMenus = int.Parse(Console.ReadLine());
int numberOfFishMenus = int.Parse(Console.ReadLine());
int numberOfvegetarianMenus = int.Parse(Console.ReadLine());

const double chickenMenuPrice = 10.35;
const double fishMenuPrice = 12.40;
const double vegetarianMenuPrice = 8.15;

double totalCostOfMenus = numberOfchickenMenus * chickenMenuPrice + numberOfFishMenus * fishMenuPrice + numberOfvegetarianMenus * vegetarianMenuPrice;
double dessertPrice = totalCostOfMenus * 0.2;
const double deliveryPrice = 2.50;
double totalOrderPrice = totalCostOfMenus + dessertPrice + deliveryPrice;

Console.WriteLine(totalOrderPrice);
