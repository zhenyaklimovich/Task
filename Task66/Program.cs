// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое положительное число:");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 1)
{
  Console.WriteLine("Введите положительное число!");
  return;
}
Console.WriteLine("Введите второе целое положительное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
  Console.WriteLine("Введите положительное число!");
  return;
}

int summa(int m, int n)
{
if (m==n)
return n;
else return m + summa(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");
