// Задача 69: Напишите программу, которая 
//     на вход принимает два числа A и B, 
//     и возводит число А в целую степень B с помощью рекурсии.
//         A = 3; B = 5 -> 243 (3⁵)
//         A = 2; B = 3 -> 8

int MyPow(int a, int b) {
    if (b<=0) return 1;
    return a * MyPow(a, b-1);
}

System.Console.Write("Введите два числа через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int A = lazyWrite[0];
int B = lazyWrite[1];
System.Console.WriteLine($"{A} в степени {Math.Abs(B)} будет {MyPow(A, Math.Abs(B))}");
System.Console.WriteLine($"на самом деле {A}^{B} = {Math.Pow(A, B)}");