internal class Program
{
    private static void Main(string[] args)
    {
        // Задайте массив вещественных чисел. Найдите разницу между 
        // максимальным и минимальным элементов массива.
        Console.WriteLine("Введите количество элементов массива (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n < 1)
        {
            Console.WriteLine("Это неправильное число");
            return;
        }
        int[] myArray = new int[n];
        Random rnd = new Random();
        for (int x = 0; x < n; x++)
        {
            myArray[x] = rnd.Next(10, 99);
            Console.WriteLine("index " + "[" + x + "] " + myArray[x]);
        }
        int max = 0;
        int min = 0;
        int result = 0;
        for (int x = 0; x < n; x++)
        {

            if (myArray[x] > myArray[x + 1])
            {
                max = myArray[x];
                min = myArray[x + 1];
                return;
            }
            else
            {
                min = myArray[x];
                max = myArray[x + 1];

            }

        }
        result = max - min;
        Console.WriteLine("разница между максимальным и минимальным элементом " + result);
    }
}