// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int N = Prompt("Введите число: ");
for (int i = 1; i <= N; i++)
{
    if (i == N)
    {
        Console.Write ($"{Math.Pow(i,3)}.");
    }
    else
    {
        Console.Write ($"{Math.Pow(i,3)}, ");
    }
}
