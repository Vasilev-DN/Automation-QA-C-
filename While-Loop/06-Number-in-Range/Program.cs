int number = int.Parse(Console.ReadLine());

while (true)
{
    if (number >= 1 && number <= 100)
    {
        break;
    }

    number = int.Parse(Console.ReadLine());
}

Console.WriteLine(number);


//int number = int.Parse(Console.ReadLine());

//bool isInRange = number >= 1 && number <= 100;

//while (!isInRange)
//{
    //number = int.Parse(Console.ReadLine());
    //isInRange = number >= 1 && number <= 100;
//}

//Console.WriteLine(number);
