// Задача 65: Задайте значения M и N. Напишите программу, которая 
//     выведет все натуральные числа в промежутке от M до N.
//         M = 1; N = 5 -> "1, 2, 3, 4, 5"
//         M = 4; N = 8 -> "4, 5, 6, 7, 8"

void GetNums(int m, int n) {
    if (m < n) return;
    GetNums(m-1, n);
    System.Console.Write(m + " ");
}


System.Console.Write("Введите два числа через ПОБЕЛ: ");
int[] lazyWrite = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int M = Math.Abs(lazyWrite[0]);
int N = Math.Abs(lazyWrite[1]);

if (M<N)
    GetNums(N, M);
GetNums(M, N);
System.Console.WriteLine();


Metka:
System.Console.Write("введите число M: ");
int numM = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("введите число N: ");
int numN = Convert.ToInt32(System.Console.ReadLine());

if (numM<=numN) {
    System.Console.WriteLine("пусть 'M' будет больше 'N'");
    goto Metka;
    }
GetNums(numM, numN);