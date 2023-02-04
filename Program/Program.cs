string[] FillStringArray()
{
    Console.Write("Введите количество элементов массива: ");
    int stringLength = Convert.ToInt32(Console.ReadLine());

    string[] stringArray = new string[stringLength];

    for (int i = 0; i < stringLength; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}
void ShowArray(string[] strArray)
{
    Console.WriteLine("Массив состоит из следующих элементов: ");
    for (int i = 0; i < strArray.Length; i++)
        Console.WriteLine($"{i+1}. {strArray[i]};");
}

string[] strArray = FillStringArray();
ShowArray(strArray);
