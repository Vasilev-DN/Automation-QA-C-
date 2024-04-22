int number = int.Parse(Console.ReadLine());

int tempNumber = number;
bool isSpecialNumber = true;

while (tempNumber > 0)
{
    int currentLastDigit = tempNumber % 10; // takes last digit
    tempNumber = tempNumber / 10; // removes last digit

    if (number % currentLastDigit != 0 )
    {
        isSpecialNumber = false;
        break;
    }
}

if (isSpecialNumber)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}