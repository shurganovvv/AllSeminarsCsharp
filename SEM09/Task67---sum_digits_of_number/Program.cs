// Задача 67: Напишите программу, которая 
//     будет принимать на вход число 
//     и возвращать сумму его цифр.
//         453 -> 12
//         45 -> 9

int SumDigits(int n) {
    if (n<=0) return 0;
    return n%10 + SumDigits(n/10);
}

System.Console.Write("введите число: ");
int N = Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
System.Console.WriteLine(SumDigits(N));


System.Console.WriteLine(Summ(N, 0));

int Summ(int num, int sum) {
    sum += num % 10;
    if (num < 10)
        return sum;
    return Summ(num/10, sum);
}