string[] CreateArray()
{
    Console.Write("Введите количество строк в массиве: ");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length < 0) Console.WriteLine("Ошибка! Введите положительное целое число.");
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} строку массива:    ");
        array[i] = Console.ReadLine()!;
        if (array[i] == "")
        {
            Console.WriteLine($"Вы не ввели значение {i + 1} строки");
            break;
        }
    }
    return array;
}

string[] FindShortString(string[] array)
{
    string[] resarray = new string[array.Length];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resarray[k] = array[i];
            k++;
        }
    }
    return resarray;
}

void PrintArray(string[] array)
{
    array = array.Where(x => x != null).ToArray();
    if (array.Length == 0) Console.WriteLine("[]");
    else
    {
        Console.Write("[\"");
        for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]}\",\"");
        Console.Write($"{array[array.Length - 1]}\"]");
    }
}

string[] arr = CreateArray();
PrintArray(arr);
Console.Write(" -> ");
string[] result = FindShortString(arr);
PrintArray(result);

