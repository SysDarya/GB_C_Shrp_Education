// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrix = new int [matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[j,i] = matrixOne[j,i] * matrixTwo[j,i];
        }
    }
    return matrix;
}

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int y = Prompt("Узнаем размер матриц. Введите количество строк > ");
int x = Prompt("Узнаем размер матриц. Введите количество столбцов > ");
int min = Prompt("Заполняем первую матрицу. Введите минимальный предел > ");
int max = Prompt("Заполняем первую матрицу. Введите максимальный предел > ");
int minTwo = Prompt("Заполняем вторую матрицу. Введите минимальный предел > ");
int maxTwo = Prompt("Заполняем вторую матрицу. Введите максимальный предел > ");
int[,] matrixOne = CreateMatrix(y, x, min, max);
int[,] matrixTwo = CreateMatrix(y, x, minTwo, maxTwo);
Console.WriteLine("Первая матрица > ");
PrintMatrix(matrixOne);
Console.WriteLine("Вторая матрица > ");
PrintMatrix(matrixTwo);
int[,] multiply = MultiplyMatrix(matrixOne, matrixTwo);
Console.WriteLine("Перемноженные матрицы > ");
PrintMatrix(multiply);
