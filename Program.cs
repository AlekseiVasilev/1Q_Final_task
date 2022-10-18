

Console.Clear();
Console.WriteLine("\t 1Q Final task");
string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

PrintArry(array1);
Console.Write(" -> ");
PrintArry(ModArray(array1));
Console.WriteLine("");

PrintArry(array2);
Console.Write(" -> ");
PrintArry(ModArray(array2));
Console.WriteLine("");

PrintArry(array3);
Console.Write(" -> ");
PrintArry(ModArray(array3));
Console.WriteLine("");


void PrintArry(string[] numbers)
{
    int count = numbers.Length;
    int i = 0;
    Console.Write("[");
    while (i < count)
    {
        Console.Write($"\"");
        Console.Write(numbers[i]);
        Console.Write($"\"");
        i++;
        if (i < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string[] ModArray(string[] numbers)
{
    int len = 3;
    int modSize = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i].Length <= len)
        {
            modSize++;
        }
    }
    string[] mod = new string[modSize];
    int j = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i].Length <= len)
        {
            mod[j] = numbers[i];
            j++;
        }
    }

    return mod;
}

