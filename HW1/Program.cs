//Задача2. Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//а = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max 10
//a = -9; b = -3 -> max -3

/*
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number1 > max) max = number1;
if(number2 > max) max = number2;

Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача4. Написать программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22

/*
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача6. Написать программу, которая на вход принимает число и выдает, является ли число четным 
//(делится ли оно на 2 без остатка).
//4 -> yes
//-3 -> no
//7 -> no

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
    Console.ReadLine();
}














//Задача8. Написать программу, которая на вход принимает число (N), а на выходе показывает все честные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*
Console.WriteLine("Введите Ваше число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int start = 1;

for (int i = 1; i < num; i ++)
{
    start++;
    if(start % 2 == 0)
    {
        Console.Write(start + " ");
    }

}
*/




