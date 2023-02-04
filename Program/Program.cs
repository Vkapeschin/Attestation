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
void ShowArray(string[] strArray, string name)
{
    Console.WriteLine($"Массив{name} состоит из следующих элементов: ");
    for (int i = 0; i < strArray.Length; i++)
        Console.WriteLine($"{i+1}. {strArray[i]};");
    Console.WriteLine();
}
string[] ChangeArray(string[] strArray)
{
    int size = 0;
    for (int i = 0; i < strArray.Length; i++)
        if (strArray[i].Length <= 3)
        {
            size++;
        }
    string[] changeArray = new string[size];
    size = 0;
    for (int i = 0; i < strArray.Length; i++)
        if (strArray[i].Length <= 3)
        {
            changeArray[size] = strArray[i];
            size++;
        }    
    return changeArray;
}

string[] strArray = FillStringArray();
string name = ", введенный пользователем,";
ShowArray(strArray, name);
string[] changeArray = ChangeArray(strArray);
name = " после выборки";
ShowArray(changeArray, name);