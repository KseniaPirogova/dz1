// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int y = x/2;

if (y is double) 
    Console.WriteLine("нет");
else
    Console.WriteLine("да");