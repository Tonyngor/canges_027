// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Задайте прямоугольный двумерный массив m,n");
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив:");
Console.WriteLine();
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            matrix[i, j] = new Random().Next(0, 9);
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
int[,] matrix = new int[m, n];
PrintArray(matrix);
// Console.WriteLine("Суммы строк:");
Console.WriteLine();
int sumrows = 0;
int i = 0;
int[] array = new int[m];
for (i = 0; i < m ; i++)
{
    for (int j = 0; j < n ; j++)
    {
        sumrows = sumrows + matrix[i, j];

    }
    array[i] = sumrows;
    // Console.Write($"{sumrows}" + "  ");
    sumrows = 0;
}
Console.WriteLine();
int minnumber = array[0];
int minnumbervalue = 0;
int minindexvalue = 0;
int minindex = 0;
for (i = 0; i + 1 < m; i++)
{
    if (array[i] <= array[i + 1])
    {
        minindexvalue = i;
        minnumbervalue = array[i];
    }
    else
    {
        minindexvalue = i + 1;
        minnumbervalue = array[i + 1];
    }
    if (minnumbervalue <= minnumber)
    {
        minnumber = minnumbervalue;
        minindex = minindexvalue;
    }
}
// Console.WriteLine("Minindex: " + minindex);
// Console.WriteLine("Minnumber: " + minnumber);
Console.WriteLine("Строка с наименьшей суммой элементов: ");
for (i = 0; i < m ; i++)
{
    if ( array[i] == minnumber)
    {
        Console.Write($"{i}" + ", ");
    }
    

} 
