// Задача 64:
// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
void printNumbers()
{
    Console.WriteLine("Задайте натуральное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Натуральные числа от N до 1:");
    while (n > 0)
    {
        Console.Write($"{n}, ");
        n = n - 1;
    }
}
printNumbers();