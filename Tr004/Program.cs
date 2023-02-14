//Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число n:");
int abc = int.Parse(Console.ReadLine());
int value = abc;
if (value < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
while (value > 1000)
{
    value = value / 10;
}
value = value % 10;
Console.WriteLine(value);