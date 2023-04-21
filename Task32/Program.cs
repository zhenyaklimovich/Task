﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max)
{
int[] arr = new int [size];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
}

void InverseArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] *= -1;
}
}


int[] array = CreateArrayRndInt(5, -9, 9);
Console.Write("[");
PrintArray(array);
Console.Write("]");
InverseArray(array);
Console.WriteLine();
Console.Write("[");
PrintArray(array);
Console.Write("]");
