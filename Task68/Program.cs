/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

// Console.WriteLine("Введите неотрицательное число: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите неотрицательное число: ");
// int n = int.Parse(Console.ReadLine()!);

int ackerman(int n, int m)
{
  if (n == 0)
  {
    return (m + 1);
  }
  else

    if (m == 0)
  {
    return ackerman(n - 1, 1);
  }
  else
  {
    return ackerman(n - 1, ackerman(n, m - 1));
  }

}

Console.WriteLine(ackerman(2, 3));
