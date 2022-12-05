void NewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]}  ");
        }
    }
}

Console.WriteLine("Введите через пробел строки массива: ");
string[] array = Console.ReadLine().Split();
Console.WriteLine();
Console.WriteLine("Вывод строк с 3 и менее символами: ");
NewArray(array);
