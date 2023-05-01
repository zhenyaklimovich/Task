// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки элемента матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

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

void SearchMatrix(int[,] matrix, int rows, int columns) 
{
  bool flag = false;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == rows && j == columns)
      {
        Console.WriteLine($"Искомый элемент: {matrix[rows, columns]}");
        flag = true;
        break;
      }
    }
  }
  if (!flag)
  {
    Console.WriteLine("Такого элемента не существует!");
  }
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

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
SearchMatrix(array2d, rows, columns);