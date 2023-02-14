// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());
string[] days = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
day = day - 1;
if (day > 4 && day < 7 )
{
    Console.WriteLine("Это выходной день!");
}
else
{
Console.WriteLine("Это будний день!");
}
