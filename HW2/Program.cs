//Задача10. Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


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







