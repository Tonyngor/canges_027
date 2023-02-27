internal class Program
{
    private static void Main(string[] args)
    {
        //Задайте одномерный массив, заполненный случайными числами.
        //Найдите сумму элементов, стоящих на нечётных позициях.
        Console.WriteLine("Введите количество элементов массива (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n < 1)
        {
            Console.WriteLine("Это неправильное число");
            return;
        }
        int[] myArray = new int[n];
        int sum = 0;
        Random rnd = new Random();
        if (n < 2)
        {
            Console.WriteLine("Нечетных позиций нет");
            return;
        }
        for (int x = 0; x < n; x++)
        {
            myArray[x] = rnd.Next(-100, 100);
            Console.WriteLine("index " + "[" + x + "] " + myArray[x]);
            if (x % 2 == 1)
            {
                sum = sum + myArray[x];
            }
        }
        Console.WriteLine("Сумма элементов нечетных позиций: " + sum);
    }
}