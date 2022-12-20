int number = new Random().Next();

//ИЛИ вот так получаем число
//Console.WriteLine("Введите число");
//int number = int.Parse(Console.ReadLine());
Console.WriteLine(number);

int thirdint = 0;
if(number > 999)
{
    while(number > 999)
    {
        number = number / 10;    
    }
}
if( number > 99)
{
    thirdint = number % 10;
    Console.WriteLine($"Третья цифра вот: {thirdint}");
}
    else if(number < 100)
    {
       Console.WriteLine("Нет третьей цифры"); 
    }