//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите два числа: ");

string str = Console.ReadLine()!;
string[] parts = str.Split(" ");
int a = int.Parse(parts[0]);
int b = int.Parse(parts[1]);
int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine($"Максимальное число {max}");
Console.WriteLine($"Минимальное число {min}");

