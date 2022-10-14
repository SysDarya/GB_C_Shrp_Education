// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Функция должна на вход принимать число, а выдавать сумму его цифр

int InputNumber(string msg)
{
    System.Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumCount (int number)
{
    int sum = 0;
    int part = 0;
    if (number>0)
    {
        while (number > 0)
        {
            part = number % 10;
            sum = sum + part;
            number = number / 10;
        }
    }
    else 
    {
        number = number * -1;
        while (number > 0)
        {
            part = number % 10;
            sum = sum + part;
            number = number / 10;
        }
    }
    return sum;
}

bool ValidateNumber(int number)
{
    if (number < 9 && number > -9)
    {
        System.Console.WriteLine("ОШИБКА!!! НЕВОЗМОЖНО ВЫЧИСЛИТЬ!!! Пожалуйста, введите число, состоящее из нескольких цифр.");
        return false;
    }
    return true;
}

int n = InputNumber("Введите число >>> ");
if (ValidateNumber(n))
{
    int result = SumCount(n);
    System.Console.WriteLine($"Сумма цифр вашего числа равна {result}.");
}