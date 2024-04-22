int countOfDays = int.Parse(Console.ReadLine());

for (int currentDay = countOfDays; currentDay > 0; currentDay--)
{
    Console.WriteLine($"{currentDay} days before the exam");
}

Console.WriteLine("The exam has come");