// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


int tmp1 = 0;
int tmp2 = 1;

while(count  > 0)
{
   int tmp = tmp1 + tmp2;
   System.Console.WriteLine($"{tmp1}");
   tmp1 = tmp2;
   tmp2 = tmp;
   count--;
}

