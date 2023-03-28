//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Aсkerman(int m, int n) 
{
    if (m == 0) 
      return (n + 1); 

    else
      if (m > 0 && n == 0) 
        return Aсkerman(m - 1, 1);

    else 
      return Aсkerman(m - 1, Aсkerman(m, n - 1));
}

int m = Prompt("Input M: ");
int n = Prompt("Input N: ");

Console.WriteLine($"A({m}, {n}) = {Aсkerman(m, n)}");