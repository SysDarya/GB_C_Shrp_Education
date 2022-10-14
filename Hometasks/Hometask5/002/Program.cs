// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumOfOddIndexes(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = CreateArray(4, -10, 10);
PrintArray(array);
int result = SumOfOddIndexes(array);
Console.WriteLine ($"Сумма чисел под нечетными индексами равна {result}.");