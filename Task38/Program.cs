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
else Console.Write($"{round}");
}
}
double[] array = CreateArrayRndDouble(12, -9, 9);

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("В массиве: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] > max)
        {
            max = numbers[n];
        }
    if (numbers[n] < min)
        {
            min = numbers[n];
        }
}

Console.WriteLine($" - {numbers.Length} элементов. Максимальное значение = {max}, минимальное значение = {min}");
double round = Math.Round(max - min, 1);
Console.WriteLine($"Разница между максимальным и минимальным значением = {round}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 10;
        }
}

