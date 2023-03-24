// Задача 28: Напишите программу, которая 
//     принимает на вход число N 
//     и выдаёт произведение чисел от 1 до N.
//         (факториал)
//         4 -> 24 
//         5 -> 120

// пример работы метода TryParse(str, out int integer);
// System.Console.WriteLine("ввод");
// string strN = Console.ReadLine();
// if (int.TryParse(strN, out int N))
//     System.Console.WriteLine("");
// else
//     System.Console.WriteLine("Введено не число!");


int GetNumber(string txt)
{
    System.Console.Write(txt);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Factorial(int x)
{
    int fac = 1;
    for (int i = 1; i <= x; i++) fac *= i;
    return fac;
}

int N = GetNumber("Принимаю на вход число N: ");
if (N > 0)
{
    System.Console.WriteLine($"Факториал числа {N} вычисляестся:");
    System.Console.WriteLine($"{N}! = {Factorial(N)}");
    System.Console.Write(N + "! = ");
    int fac = 1;
    for (int i = 1; i < N; i++)
    {
        fac *= i;
        System.Console.Write($"{i} + ");
    }
    fac *= N;
    System.Console.WriteLine($"{N} = {fac}");
}
else if (N == 0)
    System.Console.WriteLine("Факториал нуля равен единице: 0!=1");
else
    System.Console.WriteLine("Факториал отрицательного числа не вычисляется!");