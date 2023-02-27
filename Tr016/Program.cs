// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
Console.WriteLine("Введите количество элементов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 2)
{
    Console.WriteLine("Результата нет");
    return;
}
int[] myArray = new int[n];
Random rnd = new Random();
int max = 0;
int min = 11;
int result = 0;
int x = 0;
myArray[x] = rnd.Next(-10, 10);
Console.WriteLine("index " + "[" + x + "] " + myArray[x]);
int i = myArray[x];
myArray[x] = rnd.Next(-10, 10);
Console.WriteLine("index " + "[" + 1 + "] " + myArray[x]);
int j = myArray[x];
if (j < i)
{
    max = i;
    min = j;
}
else
{
    max = j;
    min = i;
}
for (x = 2; x < n; x++)
{
    myArray[x] = rnd.Next(-10, 10);
    Console.WriteLine("index " + "[" + x + "] " + myArray[x]);
    i = myArray[x];
    if (j < i)
    {
        if (i > max)
        {
            max = i;
        }
        if (i < min)
        {
            min = i;
        }
    }
    else
    {
        if (i > max)
        {
            max = i;
        }
        if (i < min)
        {
            min = i;
        }
    }
    j = myArray[x];
    result = max - min;
}
Console.WriteLine("Разница между максимальным и минимальным элементом: " + result);
