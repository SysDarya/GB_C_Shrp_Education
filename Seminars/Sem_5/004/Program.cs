// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

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

int[] myArray = CreateArray(10, 0, 200);
PrintArray (myArray);

int CountNumbers(int[] array)
{
    int count = 0;

        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 10 && array[i] <= 99)
                {
                    count++;
                }

            }
    return count;
}

Console.WriteLine($"Количество элементов, которые лежат в отрезке [10-99]: {CountNumbers(myArray)}");
