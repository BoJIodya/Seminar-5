void RandomArray(int[] array) // заполение массива положительными трехзначными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    //return array;
}

void PrintArray(int[] array) // печать массива, для проверки
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int PositiveNumbers(int[] array) // подсчет четных элементов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = new int[5];
RandomArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(PositiveNumbers(array));