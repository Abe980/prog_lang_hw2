// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100 || number > 999)
// {
//     Console.WriteLine("Число введено некорректно");
// }
// else
// {
// int secondSym = number / 10 % 10;

// Console.WriteLine($"Вторая цифра {secondSym}");
// }




// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного семизначного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите семизначное число: ");
// int num7 = Convert.ToInt32(Console.ReadLine());

// if (num7 < 1000000 || num7 > 9999999)
// {
//     Console.WriteLine("Число не семизначное");
//     if (num7 < 100) Console.WriteLine("и третьей цифры там нет");
// }
// else
// {
// int sym3 = num7 / 10000 % 10;

// Console.WriteLine($"Третья цифра {sym3}");
// }




// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7) 
{
    Console.WriteLine("Не корректно введено число");
}
else
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("День является выходным");
    }
    else
    {
        Console.WriteLine("День не является выходным");
    }
}