// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход число (N) 
        // и выдаёт таблицу кубов чисел от 1 до N.
        Console.WriteLine("Введите положительное число");
        int n = Convert.ToInt32(Console.ReadLine());
        int value = 0;
        int x = 0;
        if (n < 1)
        {
            Console.WriteLine("Это неправильное число");
        }
        else
        {
            while (value < n)
            {
                value = value + 1;
                x = value * value * value;
                Console.WriteLine(x);
            }
        }
    }
}
