//Задайте значения M и N. 
//Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Recursion(int m, int n) 
{
    if (m < n)
        return 0;  
    return (n + Recursion(n - 1));
}

Console.WriteLine(Recursion(1, 15));