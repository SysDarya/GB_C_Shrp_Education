// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int y,int x, int minLimit, int maxLimit)
{
    int[,] matrix = new int[y,x];
    Random rnd = new Random();
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
           matrix[j,i] = rnd.Next(minLimit, maxLimit + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            System.Console.Write($"{matrix[j,i]}  ");
        }
    System.Console.WriteLine();;
    }
}

float[] FindSum (int[,] matrix)
{
    float[] array = new float [matrix.GetLength(1)];
    int c = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        // int average = 0;
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];
        }
        // average = sum / matrix.GetLength(0);
        array[c] = sum;
        c++;
    }
    return array;
}

void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{Math.Round(array[i], 2)}   ");
    }
    System.Console.WriteLine();
}

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int y = Prompt("Узнаем размер матрицы. Введите количество строк > ");
int x = Prompt("Узнаем размер матрицы. Введите количество столбцов > ");
int min = Prompt("Заполняем матрицу. Введите минимальный предел > ");
int max = Prompt("Заполняем матрицу. Введите максимальный предел > ");
int[,] myMatrix = CreateMatrix(y, x, min, max);
Console.WriteLine("Ваша матрица > ");
PrintMatrix(myMatrix);
float[] result = FindSum(myMatrix);
Console.WriteLine("Среднее арифметическое столбцов равно > ");
PrintArray(result);