// Задача 1: Напишите 
// Сумма чисел от 1 до number
int SumNumbers(int number)
{
    int sum = 0;        // Тут накапливаем сумму
    for (int i = 1; i <= number; i++)    // цикл от 1 до number
    {
        sum = sum + i;  // суммируем
    }
    return sum;     // возврат суммы из метода
}

// проверка на правильност ввода
bool ValidateNumber(int number)
{
    if (number < 1) // При числе меньше чем 1 не работаем
    {
        System.Console.WriteLine("Число меньше единицы, сумма не считается");
        return false;
    }
    return true;
}
int n = InputNumber("Введите число >");
if (ValidateNumber(n))
{
    int result = SumNumbers(n);
    System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");
}

