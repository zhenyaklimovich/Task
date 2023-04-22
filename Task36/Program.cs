// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] array = CreateArrayRndInt(5, 99, 1000);

int temp = 0;

WriteArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        temp += array[i];
    }
    else continue;
}
Console.WriteLine($"Sum odd count: {temp}");


void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}