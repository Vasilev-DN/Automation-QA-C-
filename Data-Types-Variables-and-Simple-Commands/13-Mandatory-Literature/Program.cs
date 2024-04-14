int numberOfpages = int.Parse(Console.ReadLine());
int pagesPerhour = int.Parse(Console.ReadLine());
int neededDays = int.Parse(Console.ReadLine());

int hoursPerday = numberOfpages / pagesPerhour /  neededDays;

Console.WriteLine($"{hoursPerday}");