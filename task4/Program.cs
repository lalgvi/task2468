//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите три числа: ");

string str = Console.ReadLine()!;
string[] parts = str.Split(" ");
int a = int.Parse(parts[0]);
int b = int.Parse(parts[1]);
int c = int.Parse(parts[2]);
int max = 0;

if (a > b) max = a;
else max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное число {max}");



