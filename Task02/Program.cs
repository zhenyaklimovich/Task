// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите два неравных друг другу целых числа");
if (int.TryParse(Console.ReadLine(), out var firstNumber))
{
    Console.WriteLine($"Хорошо, ваше число {firstNumber}");
}
else
{
    Console.WriteLine("Ввод не является целым числом");
}
if (int.TryParse(Console.ReadLine(), out var secondNumber))
{
    Console.WriteLine($"Отлично, ваше число {secondNumber}");
}
else
{
    Console.WriteLine("Ввод не является целым числом");
}

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Большее число {firstNumber}, меньшее число {secondNumber}");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine($"Большее число {secondNumber}, меньшее число {firstNumber}");
}
else
{
    Console.WriteLine("Введены некорректные или равные значения, попробуйте еще разок");
}