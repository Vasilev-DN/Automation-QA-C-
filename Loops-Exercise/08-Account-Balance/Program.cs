double balance = 0;

while (true)
{
    string text = Console.ReadLine();

    if (text == "End")
    {
        break;
    }

    if (double.TryParse(text, out double amount))
    {
        if (amount >= 0)
        {
            balance += amount;
            Console.WriteLine($"Increase: {amount:F2}");
        }
        else
        {
            balance += amount;
            Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
        }
    }
}

Console.WriteLine($"Balance: {balance:F2}");

