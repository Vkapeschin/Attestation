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
    Console.WriteLine();
}
string[] ChangeArray(string[] strArray)
{
    int x = 0;
    for (int i = 0; i < strArray.Length; i++)
        if (strArray[i].Length <= 3)
        {
            x++;
        }
    string[] changeArray = new string[x];
    x = 0;
    for (int i = 0; i < strArray.Length; i++)
        if (strArray[i].Length <= 3)
        {
            changeArray[x] = strArray[i];
            x++;
        }    
    return changeArray;
}

string[] strArray = FillStringArray();
ShowArray(strArray);
string[] changeArray = ChangeArray(strArray);
ShowArray(changeArray);