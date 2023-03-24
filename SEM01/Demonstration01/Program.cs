// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Напишите программу, которая 
//      на вход принимает число 
//      и выдает его квадрат (число умноженное на само себя).
//          Например:
//              4 -> 16 
//              -3 -> 9 
//              -7 -> 49

Console.WriteLine("Вводи же!");     // Вывод строки в терминале
int number = Convert.ToInt32(Console.ReadLine());    // int.Pars() || Convert.ToInt32

int result = number * number;       // вычесление квадрата введённого числа
System.Console.WriteLine(result);   // вывод результата


Console.Write("Давай ещё: ");
double numberEwo = Convert.ToInt32(Console.ReadLine());
double resultEwo = numberEwo * numberEwo;
System.Console.WriteLine("Квадрат этого числа равен: " + resultEwo + "!");
System.Console.Write($"Квадрат числа {numberEwo} равен {resultEwo}: ");
System.Console.WriteLine($"если {numberEwo} возвести в квадрат, получится {resultEwo}!");