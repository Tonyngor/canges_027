internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 52.
        // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
        // элементов в каждом столбце.
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
        double column = 0;
        int numbercolumn = 0;
        for (int j = 0; j < n; j++)

        {
            column = 0;
            numbercolumn++;
            for (int i = 0; i < m; i++)
            {

                column = column + matrix[i, j];
            }
                column = column / m;
            Console.WriteLine("Среднее арифметическое столбца № " + numbercolumn + ": ");
            Console.WriteLine(column);
        }
    }
}