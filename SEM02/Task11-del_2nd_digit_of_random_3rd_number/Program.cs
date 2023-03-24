// Задача №11. Напишите программу, которая 
//     выводит случайное трехзначное число 
//     и удаляет вторую цифру этого числа.
//         456 -> 46
//         782 -> 72
//         918 -> 98

int N = new Random().Next(100, 1000);
System.Console.WriteLine($"{N}: {N/100}{N%10}");

int a = N / 100;
int b = N % 10;
System.Console.WriteLine($"{N}: {a}{b}");
int n = a*10+b;
System.Console.WriteLine(n);


int number = N/100 *10 + N%10;
System.Console.WriteLine(number);