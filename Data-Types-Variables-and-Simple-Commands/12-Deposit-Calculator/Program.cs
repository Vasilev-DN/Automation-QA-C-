double depositedAmount = double.Parse(Console.ReadLine());
int termOftheDeposit = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine()) / 100;

double totalAmount = depositedAmount + termOftheDeposit * (depositedAmount * annualInterestRate) / 12;

Console.WriteLine($"{totalAmount:F2}");