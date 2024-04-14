int countPackagesdogFood = int.Parse(Console.ReadLine());
int countPackagescatFood = int.Parse(Console.ReadLine());
double onePackagedogFoodcosts = 2.50;
double onePackagecatFoodcosts = 4.00;

double expenses = (countPackagesdogFood *onePackagedogFoodcosts) + (countPackagescatFood * onePackagecatFoodcosts);

Console.WriteLine($"{expenses:F2} lv.");



