char letter1 = char.Parse(Console.ReadLine());
char letter2 = char.Parse(Console.ReadLine());

for (char currentLetter = letter1; currentLetter <= letter2; currentLetter++)
{
    Console.Write(currentLetter + " ");
}