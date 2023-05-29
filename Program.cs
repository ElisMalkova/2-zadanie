
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// Console.Write("Введи трёхзначное число: ");
// string stringNumber = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine("вторая цифра этого числа -> " + stringNumber[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// Console.Write("Введи число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string NumberText = Convert.ToString(Number);
// if (NumberText.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + NumberText[2]);
// }
// else 
// {
//   Console.WriteLine("-> третьей цифры нет");
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine( );

Console.Write("Введи цифру, обозначающую день недели: ");
int dNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dNumber) 
{
  if (dNumber == 6 || dNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dNumber < 1 || dNumber > 7) 
  {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dNumber);