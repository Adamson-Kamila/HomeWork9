/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

void sum(int m, int n)
{
  int sum = 0;

  if (m == n)
  {
    Console.WriteLine($"{0}");
  }
  else
  {
    for (int i = m; i <= n; i++)
    {
      sum += i; //sum = sum + i

    }
  }
  Console.WriteLine($"M = {m}; N = {n} -> {sum}");

}

sum(m, n);
