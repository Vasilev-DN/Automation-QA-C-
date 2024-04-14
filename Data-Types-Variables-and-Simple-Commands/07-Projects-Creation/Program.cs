string architectName = Console.ReadLine();
int numberOfprogects = int.Parse(Console.ReadLine());
int hoursPerprogect = 3;

int neededHours = numberOfprogects * hoursPerprogect;

Console.WriteLine($"The architect {architectName} will need {neededHours} hours to complete {numberOfprogects} project/s.");