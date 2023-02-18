internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход координаты двух точек
        // и находит расстояние между ними в 3D пространстве.
        Console.WriteLine("Введите X1: ");
        double x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y1: ");
        double y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите z1: ");
        double z1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите X2: ");
        double x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y2: ");
        double y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите z2: ");
        double z2 = Convert.ToInt32(Console.ReadLine());

        double resalt = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
        Console.WriteLine(resalt);
    }
}