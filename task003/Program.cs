// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели от 1 до 7 и узнайте выходной ли он: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0 || number > 7)
{
    Console.WriteLine("такого дня недели нет");
}
else if (number >= 1 && number <= 5)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("ДА!");
}