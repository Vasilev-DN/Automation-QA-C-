int annualBasketballTrainingFee = int.Parse(Console.ReadLine());

double basketballSneakers = annualBasketballTrainingFee * 0.6;
double basketballTeam = basketballSneakers * 0.8;
double basketball = basketballTeam * 0.25;
double basketballAccessories = basketball * 0.2;

double totalCost = annualBasketballTrainingFee + basketballSneakers + basketballTeam + basketball + basketballAccessories;

Console.WriteLine(totalCost);

