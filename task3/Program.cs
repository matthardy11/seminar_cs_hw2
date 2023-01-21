// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите номер дня недели (1 - 7): ");

int number = Convert.ToInt32(Console.ReadLine());

if (number>7)
{
  System.Console.WriteLine("Такого дня недели нет");
}
else if (number == 6 || number == 7)
{
  System.Console.WriteLine("Выходной");
}
else
{
  System.Console.WriteLine("Не выходной");
}