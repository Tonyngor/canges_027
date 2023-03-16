// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.

void printSum()
{
    Console.WriteLine("Задайте натуральные числа M и N: ");
    Console.WriteLine("Введите число M:");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N:");
    int numberN = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    if (numberN < numberM)
    {
        while (numberM +1 > numberN)
        {
            sum = sum + numberM;
            numberM--;
        }
    }
    else
    {
        while (numberM < numberN + 1)
        {
            sum = sum + numberM;
            numberM++;
        }
    }
    Console.Write($"сумма натуральных элементов в промежутке от M до N: {sum}");
}
printSum();