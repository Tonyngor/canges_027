// Задча 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив:");
Console.WriteLine();
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            matrix[i, j] = new Random().NextDouble
            () * 20 - 10;
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
double[,] matrix = new double[m, n];
PrintArray(matrix);
