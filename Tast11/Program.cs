// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
// int Del (int num)
// {
// int firstDigit = num / 100;
// int secondDigit = num % 10;
// return firstDigit;
//        secondDigit;
// }

// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
// int firstDigit = number / 100;
// int secondDigit = number % 10;
// Console.Write(firstDigit);Console.Write(secondDigit);


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
int DeleteCentr (int num)
{
int first = num / 100;
int third = num % 10;
int answer = first * 10 + third;
return answer;
}

Console.WriteLine($" Двузначное число {DeleteCentr(number)}");
