internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите метод, который задаёт массив из N элементов и выводит их на экран.
        Console.WriteLine("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Массив");
        int index = 0;
        while (n > 0)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 1000);
            Console.WriteLine("index " + "[" + index + "] " + value);
            index++;
            n = n - 1;
        }
    }
}