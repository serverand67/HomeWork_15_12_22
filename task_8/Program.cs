/* Задача 8. Напишите программу, которая на вход принимает число N, а на выходе показывает
ве четные числа от 1 до N */


Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int temp = 2;

while(temp <= N)
{
Console.WriteLine(temp);
temp = temp + 2;
}
