﻿Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int num) 
{
    if (num > 0) return;
    Console.Write($"{0} ", num);
    NaturalNumbers(num - 1);

}

NaturalNumbers(number);