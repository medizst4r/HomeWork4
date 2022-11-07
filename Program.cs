//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Exp(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Input a number A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exp(numberA, numberB);
  Console.WriteLine("Number A to the power of A " + exponentiation);

*/
//Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
  int SumNumber(int number)
  {
    
    int count = Convert.ToString(number).Length;
    int adv = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      adv = number - number % 10;
      result = result + (number - adv);
      number = number / 10;
    }
   return result;
  }

Console.WriteLine("Input a number: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number of digits {SumNumber(a)}");
*/