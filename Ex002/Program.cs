﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int Number =  Convert.ToInt32(Console.ReadLine());

if (Number / 100 > 0)
{
    Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 1 % 10}");
}
else 
{
    Console.WriteLine($"У числа {Number} нет третьей цифры");
}

