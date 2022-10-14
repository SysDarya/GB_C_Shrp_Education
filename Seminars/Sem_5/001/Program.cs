// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Sum(int[] array, int fl = 1)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * fl > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] arr = CreateArray(8, -9, 9);
PrintArray(arr);
int sumPositive = Sum(arr);
int sumNegative = Sum(arr, -1);
System.Console.WriteLine($"Положительная сумма {sumPositive}, Отрицательная сумма {sumNegative}");
