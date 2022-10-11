// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). 
// Использовать свои функции, не использовать Math.Pow

int[] InputNumbers(string msg)
{
    System.Console.WriteLine(msg);
    int numberA = Convert.ToInt32(Console.ReadLine());
    int numberB = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [] {numberA, numberB};
    return array;
}


bool ValidateNumbers(int [] collection)
{
   if (collection[1] == 0)
   {
       Console.WriteLine ("Ваш ответ: 1.");
       return false;
    }
    return true;
}

int MathPow (int[] collection)
{
    int pow = 1;
    for(int i = 0; i < collection[1]; i++)
    {
        pow = collection[0]*pow;
    }
    return pow;
}

int [] n = InputNumbers("Введите числа A и B: ");
if (ValidateNumbers(n))
{
    int power = MathPow(n);
    Console.WriteLine($"Ваш ответ: {power}.");
}