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
int[,] matrixFirst = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrixFirst);


Console.WriteLine($"Вторая матрица:");
int[,] matrixSecond = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matrixSecond);

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


// void ShowArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
// {
//     for (int i = 0; i < resultMatr.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatr.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firstMatr.GetLength(1); k++)
//             {
//                 sum += firstMatr[i, k] * secondMatr[k, j];
//             }
//             resultMatr[i, j] = sum;
//         }
//     }
// }

// // // Console.Write("Введите количество строк 1 массива: ");
// int rowsFirstMatrix = rows(firstMatrix);
// // // Console.Write("Введите количество столбцов 1 массива: ");
// // int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
// // // Console.Write("Введите количество строк 2 массива: ");
// // int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
// // // Console.Write("Введите количество столбцов 2 массива: ");
// // int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());

// if (columnsFirstMatrix != rowsSecondMatrix)
// {
//     Console.WriteLine("Такие матирицы перемножать нельзя!");
//     return;
// }


// int[,] resultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];

// MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// ShowArray(resultMatrix);
