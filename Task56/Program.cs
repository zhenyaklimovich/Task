// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строк

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns]; 
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) 
{
for (int j = 0; j < matrix.GetLength(1); j++) 
{
matrix[i, j] = rnd.Next(min, max + 1);
}
}
return matrix;
}

void PrintMatrix (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write("|");
Console.Write($"{matrix[i, j], 5} ");
}
Console.WriteLine(" |");
}
}

int[,] array2d = CreateMatrixRndInt(20, 10, 1, 100);
PrintMatrix(array2d);

int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void FindingMinimumAmount(int[,] array)
{
    int rowMinSum = 0;
    int minSum = SumLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLine(array, i);
        if (minSum > tempSumLine)
        {
            minSum = tempSumLine;
            rowMinSum = i;
        }
    }

    Console.WriteLine($"\nНаименьшая сумма элементов {minSum}, в строке {rowMinSum + 1}");
}

FindingMinimumAmount(array2d);