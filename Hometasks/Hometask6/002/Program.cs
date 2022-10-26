// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

float Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

var k1 = Prompt("Введите k1 > ");
var b1 = Prompt("Введите b1 > ");
var k2 = Prompt("Введите k2 > ");
var b2 = Prompt("Введите b2 > ");

var x = (b2 - b1)/(k1 - k2);
var y = k1 * x + b1;

Console.WriteLine($"Прямые пересекаются в точке: ({x};{y}.)");