internal class Program
{
    private static void Main(string[] args)
    {
        // Пользователь вводит с клавиатуры M чисел. 
        // Посчитайте, сколько чисел больше 0 ввёл пользователь.
        // Подзадачи:
        // Ограничить количество M чисел
        // Обозначить пределы максимального и минимального числа
        Console.WriteLine("Введите количество чисел (m): ");
        int m = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        if (m < 1 || m > 10)
        {
            Console.WriteLine("Неправильное число. Начните заново ");
            return;
        }
        Console.WriteLine("Введите " + m + " чисел");
        while (m > 0)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 9 || number < -9)

            {
                Console.WriteLine("Неправильное число. Начните заново");
                return;
            }
            if (number > 0)
            {
                result = result + 1;
            }
            m--;
        }

        Console.WriteLine("Количество чисел больше нуля : " + result);
    }
}