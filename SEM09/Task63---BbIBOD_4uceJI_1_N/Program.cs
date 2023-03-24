// Задача 63: Задайте значение N. Напишите программу, которая 
//     выведет все натуральные числа в промежутке от 1 до N.
//         N = 5 -> "1, 2, 3, 4, 5"
//         N = 6 -> "1, 2, 3, 4, 5, 6"

void GetNums(int n) {
    if (n == 0) return;
    GetNums(n-1);
    System.Console.Write(n + " ");
}

System.Console.Write("введите число N: ");
int N = Convert.ToInt32(System.Console.ReadLine());
GetNums(N);