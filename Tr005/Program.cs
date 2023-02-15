int[] Array = new int[] { 1,2,3,4,5,6,7 };
int Index = 0;
int size = Array.Length;
if (size < 3)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (Index < 2)
    {
        Index = Index + 1;
    }
    Console.WriteLine(Array[Index]);
}