﻿//Задайте значения M и N. 
//Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Sum(int m, int n) 
{
    if (m == n)
        return m;  
    return (Sum(m, n - 1) + n);
}

int m = Prompt("Input M: ");

int n = Prompt("Input N: ");
if (n < m)
{
  Console.WriteLine("Input n > m");
  return;
}

Console.WriteLine(Sum(m, n));