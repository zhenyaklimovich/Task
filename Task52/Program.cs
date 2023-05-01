// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] EvenElements(int[,] matrix)
{
double[] result = new double[matrix.GetLength(1)];
for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      result[j] += matrix[i, j];
    }
    result[j] = Math.Round(result[j] / matrix.GetLength(0), 1);
  }
  
return result;

}

void PrintMatrix (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i, j], 5} ");
}
Console.WriteLine(" |");
}
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);
EvenElements(array2d);
double[] evenElements = EvenElements(array2d);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", EvenElements(array2d))}");




