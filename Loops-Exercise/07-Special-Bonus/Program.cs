int stopNumber = int.Parse(Console.ReadLine());

int previousNumber = 0;
int currentNumber = 0;

while (true)
{
    currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber == stopNumber)
    {
        break;
    }

    previousNumber = currentNumber;
}

double bonusAmount = previousNumber * 0.2;
double bonusResult = previousNumber + bonusAmount;

Console.WriteLine(bonusResult);
 
