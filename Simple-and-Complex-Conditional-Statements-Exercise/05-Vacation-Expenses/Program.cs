string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double totalCosts = 0;

if (season == "Spring")
{
    if (accommodationType == "Hotel")
    {
        totalCosts = (days * 30) * 0.8;
    }
    else if (accommodationType == "Camping")
    {
        totalCosts = (days * 10) * 0.8;
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        totalCosts = days * 50;
    }
    else if (accommodationType == "Camping")
    {
        totalCosts = days * 30;
    }
}
else if (season == "Autumn")
{
    if (accommodationType == "Hotel")
    {
        totalCosts = (days * 20) * 0.7;
    }
    else if (accommodationType == "Camping")
    {
        totalCosts = (days * 15) * 0.7;
    }
}
else if (season == "Winter")
{
    if (accommodationType == "Hotel")
    {
        totalCosts = (days * 40) * 0.9;
    }
    else if (accommodationType == "Camping")
    {
        totalCosts = (days * 10) * 0.9;
    }
}

    Console.WriteLine($"{totalCosts:F2}");


