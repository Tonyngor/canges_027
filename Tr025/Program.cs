// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.
Console.WriteLine("Задайте трехмерный массив m,n,p:");
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число p:");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив:");
Console.WriteLine();
void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
        matrix[i, j, k] = new Random().Next(10, 99);
        Console.Write($"({matrix[i, j, k]})  " + "["+i+ ","+j+","+k+ "].    "  );
            }
        }    
    }
}
Console.WriteLine();
Console.WriteLine();

int[,,] matrix = new int[m, n, p];
PrintArray(matrix);
