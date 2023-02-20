// Заменить в тексте букву к на букву К.
// к маленькую на К большую.

string text = " Привет крокодил дела ";
string Replace(string text, char x, char y)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)

    {
        if (text[i] == x) result = result + $"{y}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string y = Replace(text, 'к', 'К');
Console.WriteLine(y);
