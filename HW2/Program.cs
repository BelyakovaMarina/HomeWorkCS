//Задача10. Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*
int SecondNum(int number)
{
    int two_digit = number % 100;
    int new_num = two_digit / 10;
    return new_num;
}

Console.WriteLine("Input your 3digit number: ");
int new_num = Convert.ToInt32(Console.ReadLine());
int res = SecondNum(new_num);
Console.WriteLine($"Second digit of your number is: " + res);
*/

//Задача13. Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6 


/*
int ThirdNum(int number)
{
    if(number < 100 )
    {
        Console.WriteLine("Third digit is not here!");
    }
    if (number >= 100 && number <= 1000)
    {
        int number_third = number % 10;
        Console.WriteLine("Third digit of your number is: " + number_third);
    }
    if (number >= 1000) 
    {
        while (number >= 1000)
        {
          int new_num = number / 10; 
          number = new_num;
        }
        
        int number_third = number % 10;
        Console.WriteLine("Third digit of your number is: " + number_third);
    }
    return number;
 }

Console.WriteLine("Input your number: ");
int new_num = Convert.ToInt32(Console.ReadLine());
int res = ThirdNum(new_num);
*/




//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
    Console.WriteLine("Да, это выходной день!");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Эта цифра не является днем недели!");
  }
  else Console.WriteLine("Нет, этот день не выходной!");
}

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

CheckingTheDayOfTheWeek(dayNumber);

