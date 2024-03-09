// На основе символов строки (string) сформировать массив сиволов типа (Char[])
// пример
// "Hello!"  =   ['H', 'E', 'L', 'L' ,'O', '!']



Console.WriteLine("Напишите слово");
string str = Console.ReadLine();

char[] array = StringToCharArray(str);
PrintArray(array);


static char[] StringToCharArray(string str)
{
    char[] charsArray = new char[str.Length];
    for (int i = 0; i < charsArray.Length; i++)
    {
        charsArray[i] = str[i];
    }
    return charsArray;
}

static void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

