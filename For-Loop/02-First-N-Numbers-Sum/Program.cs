int number = int.Parse(Console.ReadLine());
int sum = 0;
string numbers = "";

for (int i = 1; i <= number; i++)
{
    sum += i;
    numbers += i;
    if (i < number)
    {
        numbers += "+";
    }
}

Console.WriteLine($"{numbers}={sum}");