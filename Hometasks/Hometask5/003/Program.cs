// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

float[] CreateArray(int len, int minLimit, int maxLimit)
{
    float[] array = new float[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

float FindMax(float[] array)
{
    float max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

float FindMin(float[] array)
{
    float min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

float[] array = CreateArray(4, -10, 10);
PrintArray(array);
float max = FindMax(array);
float min = FindMin(array);
Console.WriteLine($"Разность максимального и минимального значений массива равна {max-min}.");