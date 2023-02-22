/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

string naturNumbers(int num)
{
  if (num == 1) return $"{num}";
  else
  {
    return $"{num}," + naturNumbers(num - 1);
  }

}

Console.WriteLine($"N = {num} -> " + naturNumbers(num)); // 10 9 8 7 6 53 
Console.ReadLine();



