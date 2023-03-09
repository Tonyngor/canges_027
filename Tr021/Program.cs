// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив:");
Console.WriteLine();
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            matrix[i, j] = new Random().Next(1, 99);
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
int[,] matrix = new int[m, n];
PrintArray(matrix);
Console.WriteLine("Введите позицию i: ");
int i = Convert.ToInt32(Console.ReadLine());
if (i >= m)
{
    Console.WriteLine("Такого элемента нет ");
    return;
}
Console.WriteLine("Введите позицию j: ");
int j = Convert.ToInt32(Console.ReadLine());
if (j >= m)
{
    Console.WriteLine("Такого элемента нет ");
    return;
}

    Console.WriteLine("Значение элеьента ");
    Console.WriteLine(matrix[i, j]);
