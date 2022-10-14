// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
// Постарайтесь сделать одним циклом

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,101);
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

void FindAlmoslMax (int[] collection)
{
    int leng = collection.Length;
    int max = 0;
    int SecondMax = 0;
    for (int ind = 0; ind < leng; ind++)
    {
        if (max < collection[ind])
        {
            SecondMax = max;
            max = collection[ind];
        }
        else if ( SecondMax < collection[ind])
        {
            SecondMax = collection[ind];
        }
    }
    Console.WriteLine ($"Второй максимум равен {SecondMax}.");
}

Console.Write ("Введите длину массива >>> ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int [size];
FillArray(array);
PrintArray(array);
Console.WriteLine("");
FindAlmoslMax(array);