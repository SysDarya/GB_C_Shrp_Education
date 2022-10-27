// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateMatrix(int y,int x)
{
    double[,] matrix = new double[y,x];
    Random random = new Random();
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
           matrix[j,i] = random.NextDouble() * 100;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            Console.Write($"{Math.Round(matrix[j, i], 2)}   ");;
        }
    Console.WriteLine();
    }
}

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int y = Prompt("Узнаем размер матрицы. Введите количество строк > ");
int x = Prompt("Узнаем размер матрицы. Введите количество столбцов > ");
double[,] myMatrix = CreateMatrix(y, x);
Console.WriteLine("Ваша матрица > ");
PrintMatrix(myMatrix);