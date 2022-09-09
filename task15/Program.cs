//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32 (Console.ReadLine());
if(number < 1 || number > 7)
{
Console.WriteLine ("Введено некорректное число");
}
   else if (number ==1)
{
   Console.WriteLine ("Понедельник");
}
else if (number ==2)
{
   Console.WriteLine ("Вторник");
}
else if (number ==3)
{
   Console.WriteLine ("Среда");
}
else if (number ==4)
{
   Console.WriteLine ("Четверг");
}
else if (number ==5)
{
   Console.WriteLine ("Пятница");
}
else if (number ==6)
{
   Console.WriteLine ("Суббота");
   Console.WriteLine ("Выходной день");
}
else 
{
   Console.WriteLine ("Воскресенье");
   Console.WriteLine ("Выходной день");
}