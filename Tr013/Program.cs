internal class Program
{
    private static void Main(string[] args)
    {
        //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
        //программу, которая покажет количество чётных чисел в массиве.
        Console.WriteLine("Введите количество элементов массива (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n < 1)
        {
            Console.WriteLine("Это неправильное число");
            return;
        }
        int[] myArray = new int[n];
        int result = 0;
        Random rnd = new Random();
        for (int x = 0; x < n; x++)
        {
            myArray[x] = rnd.Next(100, 999);
            Console.WriteLine("index " + "[" + x + "] " + myArray[x]);
            if (myArray[x] % 2 == 0)
            {
                result = result + 1;
            }
        }
        Console.WriteLine("Четных чисел: " + result);
    }
}