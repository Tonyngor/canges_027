// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число:");
        int abcde = Convert.ToInt32(Console.ReadLine());
        int value = abcde;
        int a = value / 10000;
        int b = value / 1000 % 10;
        int e = value % 10;
        int d = value % 100 / 10;
        if (a == e && b == d)
        {
            Console.WriteLine("Это палиндром");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
}