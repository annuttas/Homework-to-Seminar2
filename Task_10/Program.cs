// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-х значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = (n % 100) / 10;
if (n >= 100 && n < 1000)
    Console.WriteLine(result);
else
    Console.WriteLine("Ошибка. Число не трёхзначное.");