// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write ("Введите пятизначное число: ");
string number = Console.ReadLine() ?? "0";
int len = number.Length;

Console.WriteLine (" "); //для лучшего чтения в терминале

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Пожалуйста, убедитесь, что ввели число из пяти знаков, например: 12345.");
}
