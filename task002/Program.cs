﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6
//#include <cmath>

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
// if (number < 0)
// {
//     number = number * -1;
// }
// хотел сделать для отрицательного числа, но не получилось сделать модуль =(((
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    i = number % 10;
    Console.WriteLine(i);
}