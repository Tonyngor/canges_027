internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе
        Console.WriteLine("Введите число:");
        int abc = Convert.ToInt32(Console.ReadLine());
        int value = abc;
        int i = 0;
        int sum = 0;
        while (value > 0)
        {
            i = value % 10;
            sum = sum + i;
            value = value / 10;
        }
        Console.WriteLine(sum);
    }
}