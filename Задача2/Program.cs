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

int PositiveNumbers(int[] array) // суммы элементов, стоящих на нечётных позициях.
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

int[] array = new int[5];
RandomArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(PositiveNumbers(array));