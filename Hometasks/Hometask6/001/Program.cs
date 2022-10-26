// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)

int[] NumbersInArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPositive(int[] array)
{
    int count = 0;
    for(int c = 0; c < array.Length; c++)
    {
        if (array[c] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.Write("Какое количество чисел вы хотите проверить? > ");
int M = Convert.ToInt32(Console.ReadLine());
if (M > 0)
{
    int[] array = new int [M];
    Console.WriteLine("Введите ваши числа > ");
    NumbersInArray(array);
    int positive = CountPositive(array);
    Console.WriteLine($"Количество положительных чисел равно {positive}.");
}
else
{
    Console.WriteLine("ОШИБКА!!! Похоже, вы ввели число, равное нулю или меньше него. Попробуйте снова!");
}
