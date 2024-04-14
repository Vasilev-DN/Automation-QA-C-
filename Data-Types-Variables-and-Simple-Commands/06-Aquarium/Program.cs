int lenghtInSm = int.Parse(Console.ReadLine());
int widhtInSm = int.Parse(Console.ReadLine());
int heightInSm = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double volumeInSm = lenghtInSm * widhtInSm * heightInSm;
double volumeInLiters = volumeInSm * 0.001;
double occupiedSpace = 1 - percentage / 100;
double requiredLiters = volumeInLiters * occupiedSpace;

Console.WriteLine($"{requiredLiters:F2}");
