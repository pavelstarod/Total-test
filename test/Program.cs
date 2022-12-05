void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        {
            Console.Write($"{array[i]} ");
        }        
    }
    Console.WriteLine();
}

void ChangeArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}



Console.WriteLine("Введите через пробел строки массива: ");
string[] array = Console.ReadLine().Split();
string[] array2 = new string[array.Length];
ChangeArray(array, array2);
Console.WriteLine();
Console.WriteLine("Вывод массива с элементами длина которых меньше либо равна 3 символа: ");
PrintArray(array2);
