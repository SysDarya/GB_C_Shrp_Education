// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void NaturalNumber(int min, int max)
{
    if (min > max)
    {
        return;
    }
    else if (min%2 == 0)
    {
        Console.Write($"{min} ");
        NaturalNumber(min+2, max);
    }
    else
    {
        min += 1;
        Console.Write($"{min} ");
        NaturalNumber(min+2, max);
    }
}

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int n = Prompt("Введите меньшее натуральное число > ");
int m = Prompt("Введите большее натуральное число > ");
if (n < 1 || m < 0 || m < n)
{
    Console.WriteLine("ОШИБКА!!! Прочитайте условия внимательно!");
}
NaturalNumber(n, m);