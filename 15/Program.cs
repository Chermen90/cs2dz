int number = new Random().Next(1, 8);
Console.WriteLine(number);

if(number == 6 || number == 7)
{
    Console.WriteLine($"День № {number} Выходной");
}
else
{
    Console.WriteLine($"День № {number} Рабочий");
}

// ИЛИ ВОТ ТАК
Console.WriteLine("Введите число от 1 до 7");

int numbertwo = int.Parse(Console.ReadLine());
if(numbertwo == 6 || numbertwo == 7)
{
   Console.WriteLine($"День № {numbertwo} Выходной"); 
}
    else if(numbertwo > 0 && numbertwo < 6)
    {
        Console.WriteLine($"День № {numbertwo} Рабочий"); 
    }
    else
    {
       Console.WriteLine($"Вы ввели неверное число");
    }
