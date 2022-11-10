// Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

int[,] SortStrings(int[,] matrix)
{
   for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
               if(matrix[j,z] < matrix[j, z+1])
                {
                    int temp = matrix[j,z];
                    matrix[j,z] = matrix[j, z+1];
                    matrix[j, z+1] = temp; 
            }
           
           }
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

int y = Prompt("Узнаем размер матрицы. Введите количество строк > ");
int x = Prompt("Узнаем размер матрицы. Введите количество столбцов > ");
int min = Prompt("Заполняем матрицу. Введите минимальный предел > ");
int max = Prompt("Заполняем матрицу. Введите максимальный предел > ");
int[,] myMatrix = CreateMatrix(y, x, min, max);
Console.WriteLine("Ваша матрица > ");
PrintMatrix(myMatrix);
SortStrings(myMatrix);
Console.WriteLine("Отсортированная матрица > ");
PrintMatrix(myMatrix);