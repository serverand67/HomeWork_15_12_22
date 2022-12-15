/* Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным
(делится ли оно на 2 без остатка)*/

Console.Clear();
Console.WriteLine("Введите первое число");
int num = int.Parse(Console.ReadLine()!);


if (num % 2 == 0)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
