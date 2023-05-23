// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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
Console.WriteLine($"Первая матрица:");
int[,] matrixFirst = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrixFirst);



Console.WriteLine($"Вторая матрица:");
int[,] matrixSecond = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrixSecond);


if (matrixFirst.GetLength(1) != matrixSecond.GetLength(0))
{
    Console.WriteLine("Такие матирицы перемножать нельзя!");
    return;
   }

Console.WriteLine("Результирующая матрица будет:");

PrintArray(MultiplyMatrix(matrixFirst, matrixSecond));

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write("|");
            Console.Write($"{array[i,j], 5} ");
        }
    Console.WriteLine(" |");;
    }
}


int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2){
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++){
        for (int j = 0; j < matrix2.GetLength(1); j++){
            for (int k = 0; k < matrix2.GetLength(1); k++){
                resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return resultMatrix;
}