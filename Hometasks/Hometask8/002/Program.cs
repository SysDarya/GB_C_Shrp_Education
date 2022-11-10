// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] SumOfStrings(int[,] matrix)
{
   int[] array = new int [matrix.GetLength(0)];
   int count = 0;
   for (int j = 0; j < matrix.GetLength(0); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {           
            sum += matrix[j,i];
        }
        array[count] = sum;
        count++;
    }
    return array;
}

int CompareSum(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}

int[] StringToArray(int a, int[,] matrix)
{
    int[] array = new int [matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        array[i] = matrix[a, i];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();;
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
int[] sum  = SumOfStrings(myMatrix);
Console.WriteLine($"Суммы строк равны > ");
PrintArray(sum);
int stringInd = CompareSum(sum);
Console.WriteLine($"Строка с минимальной суммой находится под индексом > {stringInd} >>>");
int[] resultString = StringToArray(stringInd, myMatrix);
PrintArray(resultString);