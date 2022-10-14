// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100,101);
        index++;
    }
}

void PrintArray (int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($"{collection[position]}\t");
        position++;
    }
}

int [] array = new int [8];
FillArray(array);
PrintArray(array);
