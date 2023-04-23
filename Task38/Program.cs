// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.NextDouble() * (max - min) + min;
}
return arr;
}

void PrintArray (double[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
double round = Math.Round(arr[i], 1);
if(i < arr.Length - 1) Console.Write($"{round}, ");
else Console.WriteLine($"{round}");
}
}
double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArray(array);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

double round = Math.Round(max - min, 1);
Console.WriteLine($"Разница между максимальным и минимальным значением = {round}");



