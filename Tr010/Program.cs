internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите метод, который принимает на вход два числа (A и B)
        // и возводит число A в натуральную степень B.
        Console.WriteLine("Введите число a :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число b :");
        int b = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        int result = a;
        while (i < b)
        {
            result = result * a;
            i++;
        }
        Console.WriteLine(result);
    }
}