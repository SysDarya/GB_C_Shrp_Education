// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

bool FindElement(int[,] matrix, int a, int b)
{
    if (a <= matrix.GetLength(0) && a > -1 && b <= matrix.GetLength(1) && b > -1)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if(matrix[j,i] == matrix[a,b])
                {
                    return true;
                }
            }
        }
        return false;
    }

}

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int min = Prompt("Заполняем матрицу. Введите минимальный предел > ");
int max = Prompt("Заполняем матрицу. Введите максимальный предел > ");
int[,] myMatrix = CreateMatrix(4, 5, min, max);
Console.WriteLine("Ваша матрица > ");
PrintMatrix(myMatrix);
int y = Prompt("Введите строку > ");
int x = Prompt("Введите столбец > ");
if (FindElement(myMatrix, y, x) == true)
{
    Console.WriteLine($"Элемент под данным индексом есть и он равен {myMatrix[y,x]}.");
}
else
{
    Console.WriteLine("Такого элемента нет.");
}
