// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number;
int count = 0;

if (number < 100)
{
  System.Console.WriteLine("Третьей цифры нет");
} 
else
{
  while(tempNumber>0)                                     // поиск количества цифр в числе
  {
    count++;
    tempNumber = tempNumber/10; 
  }
}

for(int i = count; i > 3; i--)                            // уменьшение числа до 3х значного
{
  number = number/10;
}

number = number%10;                                       // получение последней цифры трехзначного числа

System.Console.WriteLine("Третье цифра числа: " + number);