int number = int.Parse(Console.ReadLine());
int powerNumber = int.Parse(Console.ReadLine());

int result = 1;

for (int i = 0; i < powerNumber; i++)
{
    result *= number;
}

Console.WriteLine(result);







