// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

int[] FindMin (int[,] matrix)
{
    int[] array = new int [matrix.GetLength(1)];
    int c = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int min = matrix[0,i];
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (min > matrix[j,i])
            {
                min = matrix[j,i];
            }
        }
        array[c] = min;
        c++;
    }
    return array;
}

int[] FindMax (int[,] matrix)
{
    int[] array = new int [matrix.GetLength(0)];
    int c = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        int max = matrix[j,0];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (max < matrix[j,i])
            {
                max = matrix[j,i];
            }
        }
        array[c] = max;
        c++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}   ");
    }
    System.Console.WriteLine();
}

int Sum (int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        sum = element + sum;
    }
    return sum;
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
int[] arrayMax = FindMax(myMatrix);
Console.WriteLine("Максимальные числа в строках > ");
PrintArray(arrayMax);
int[] arrayMin = FindMin(myMatrix);
Console.WriteLine("Минимальные числа в столбцах > ");
PrintArray(arrayMin);
int sumMax = Sum(arrayMax);
int sumMin =Sum(arrayMin);
Console.WriteLine($"Сумма максимальных равна {sumMax}. Сумма минимальных равна {sumMin}. Разность между суммой максимальных и суммой минимальных равна {sumMax - sumMin}.");