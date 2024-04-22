int number = int.Parse(Console.ReadLine());

int numsDividedBy2Mod0Cout = 0;
int numsDividedBy3Mod0Cout = 0;
int numsDividedBy4Mod0Cout = 0;

for  (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
    {
        numsDividedBy2Mod0Cout++;
    }

    if (currentNumber % 3 == 0)
    {
        numsDividedBy3Mod0Cout++;
    }

    if (currentNumber % 4 == 0)
    {
        numsDividedBy4Mod0Cout++;
    }
}

double numsDividedBy2Mod0Percentage = (double)numsDividedBy2Mod0Cout / number * 100;
double numsDividedBy3Mod0Percentage = (double)numsDividedBy3Mod0Cout / number * 100;
double numsDividedBy4Mod0Percentage = (double)numsDividedBy4Mod0Cout / number * 100;

Console.WriteLine($"{numsDividedBy2Mod0Percentage:F2}%");
Console.WriteLine($"{numsDividedBy3Mod0Percentage:F2}%");
Console.WriteLine($"{numsDividedBy4Mod0Percentage:F2}%");