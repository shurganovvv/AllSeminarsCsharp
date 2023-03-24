// Задача №1. Напишите программу, которая 
//     на вход принимает два числа 
//     и проверяет, является ли первое число квадратом второго.
//         a = 25, b = 5 -> да 
//         a = 2, b = 10 -> нет 
//         a = 9, b = -3 -> да 
//         a = -3 b = 9 -> нет



Console.WriteLine("Вводи, вводи дважды");
int number1 = Convert.ToInt32(Console.ReadLine());  
int number2 = Convert.ToInt32(Console.ReadLine());  

if ( number1 == number2 * number2 ) {
    Console.WriteLine($"О!Да: {number1} является квадратом {number2}");
    }
    else {
        Console.WriteLine($"Нет-нет - {number1} квадратом {number2} не является!");
        }
