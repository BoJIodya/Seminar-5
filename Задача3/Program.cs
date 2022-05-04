void RandomArray(double[] array) // заполение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*100, 3); //Math.Round округляет число после запятой, до указанной дроби (3 знака)
    }
}

double Diff(double[] array) // нахождение макс и мин значения и разницы между ними
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"min = {min}, max = {max}"); //для проверки
    double result = max - min;
    return result;
}

double[] array = new double[5];
RandomArray(array);
Console.WriteLine(Diff(array));