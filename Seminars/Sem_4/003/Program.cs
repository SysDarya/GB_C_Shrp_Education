// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int InputNumber(string message)
{
    Console.Write(message);
    string str = Console.ReadLine() ?? "0";
    return int.Parse(str);
}

int FactNumbers(int number)
{
    int fact = 1;        
    for (int i = 1; i <= number; i++)   
    {
        fact = fact * i;  
    }
    return fact;
}

bool ValidateNumber(int number)
{
    if (number < 1)
    {
        System.Console.WriteLine("Число меньше единицы, произведение не считается");
        return false;
    }
    return true;
}
int n = InputNumber("Введите число >");
if (ValidateNumber(n))
{
    int result = FactNumbers(n);
    System.Console.WriteLine($"Произведение чисел от 1 до {n} равно {result}");
}

