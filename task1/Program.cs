// Напишите программу которая принимает на вход трехзначное число 
// и на выхоже показывает вторую цифру этого числа

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int numb1 = number / 10;
int numb2 = numb1 % 10;

System.Console.WriteLine(numb2);