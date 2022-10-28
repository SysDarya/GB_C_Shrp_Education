// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

float[,] CreateMatrix(int y,int x, int minLimit, int maxLimit)
{
    float[,] matrix = new float[y,x];
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

void PrintMatrix(float[,] matrix)
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

double[] FindSum (float[,] matrix)
{
    double[] array = new double [matrix.GetLength(1)];
    int c = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double average = 0;
        float sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];
        }
        average = sum / matrix.GetLength(0);
        array[c] = average;
        c++;
    }
    return array;
}

void PrintArray(double[] array)
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
float[,] myMatrix = CreateMatrix(y, x, min, max);
Console.WriteLine("Ваша матрица > ");
PrintMatrix(myMatrix);
double[] result = FindSum(myMatrix);
Console.WriteLine("Среднее арифметическое столбцов равно > ");
PrintArray(result);