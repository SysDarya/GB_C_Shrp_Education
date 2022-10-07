// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// Math.Sqrt() // команда квадратный корень

const int X = 0;
const int Y = 1;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[2];
    answer[X] = Prompt($"Введите x {point} -> ");
    answer[Y] = Prompt($"Введите y {point} -> ");
    return answer;
}
int Power2(int arg)
{
    return arg * arg;
}
int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double lenght = Math.Sqrt(Power2(p1[X] - p2[X]) + Power2(p1[Y] - p2[Y])); // <- Math.Sqrt

System.Console.WriteLine($"{lenght:f2}"); // f - количество знаков после запятой.
