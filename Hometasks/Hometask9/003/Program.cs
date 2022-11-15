// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AckermannFunction (int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    if (m != 0 && n == 0) 
    {
        return AckermannFunction(m - 1, 1);
    }
    if (m > 0 && n > 0) 
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    return AckermannFunction(m, n);
}

Console.WriteLine("Введите два положительных числа: M и N.");
int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");
Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");
