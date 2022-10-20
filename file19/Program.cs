// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void FiveNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Введите число: {number} - палиндром.");
  }

  else Console.WriteLine($"Ваше число: {number} - не палиндром.");
}

if (number!.Length == 5)
{
  FiveNumber(number);
}

else Console.WriteLine($"Введи правильное число");