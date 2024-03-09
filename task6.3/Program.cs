// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1
static int GetCountVowels(string str)
{
    int count = 0;
    string vowels = "aeiouy";
    for (int i = 0; i < str.Length; i++)
    {
        char currentChar = str[i];
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == currentChar)
            {
                count++;
            }
        }
    }
    return count;
}


Console.WriteLine("Напишите слово");
string str = Console.ReadLine()!;

GetCountVowels(str);
Console.WriteLine(GetCountVowels(str));

