//Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Recursion(int n) 
{
    if (n == 2)
    {  
        Console.Write($"{n}, ");
        return 1;
    }  
    Console.Write($"{n}, ");  
    return Recursion(n - 1);

}

int n = Prompt("Input N: ");
if (n < 2)
{
  Console.WriteLine("Input n > 1");
  return;
}

Console.Write(Recursion(n));



