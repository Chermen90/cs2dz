int number = new Random().Next(100, 999);
Console.WriteLine(number);
 
int secondint = (number % 100) / 10;
Console.WriteLine($"{secondint}");
