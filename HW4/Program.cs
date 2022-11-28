// Задача 25. Написать цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);
*/

// Задача 27. Написать программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN)
  {
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
*/

// Задача 29. Написать программу, которая задаёт массив из 8 элементов и выводит их на экран.


/*
int[] CreateArr(int size)
{
  int[] array = new int[size];

  for(int i = 0; i < array.Length; i ++)
  {
    Console.Write("Input ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}

void ShowArr(int[] array)
{
  for(int i = 0; i < array.Length; i ++)
  {
    Console.Write(array[i] + " ");
  }
}

Console.Write("Введите длину массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArr(size);
ShowArr(array);
*/















