// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int abc = Convert.ToInt32(Console.ReadLine());
int value = abc;
int a = value / 100;
int ab = value / 10;
int b = ab - (a * 10);
Console.WriteLine(b);