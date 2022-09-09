//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначне число");
int number = Convert.ToInt32 (Console.ReadLine());
int count1 = number / 10;
int count2 = count1 % 10;
Console.WriteLine (count2);

