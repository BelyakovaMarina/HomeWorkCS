// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

/*
Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number.Length == 5)
{
  CheckingNumber(number);
}

else Console.WriteLine($"Введи правильное число");
*/


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15,84
// A (7,-5, 0); B (1,-1,9) -> 11,53

/*
double LongLine(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double lengthABC = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return lengthABC;
}

Console.WriteLine("Input X coordinat of A: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinat of A: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coordinat of A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinat of B: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coordinat of B: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coordinat of B: ");
int zB = Convert.ToInt32(Console.ReadLine());


double dist = LongLine(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance ABC is {dist:f2}");
*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125.

void Cube(int num)
{
    int current = 1;
    while(current <= num)
    {
        int res = current *current*current;  
        Console.Write($"{res}, ");
        current++;
    }
   Console.WriteLine($"\b\b."); 
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1)
{
    Console.Write($"{number} -> ");
    Cube(number);
}

else Console.WriteLine("imposible number!");


