// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
}

int[] array = CreateArrayRndInt(4, 99, 1000);
WriteArray(array);
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] %2 == 0)
    {
        count++;
    }
    else continue;
}
Console.WriteLine($"Количество чётных чисел в массиве: {count}");

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
