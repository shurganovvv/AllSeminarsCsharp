// Задача 44: Не используя рекурсию, 
//     выведите первые N чисел Фибоначчи. 
//     Первые два числа Фибоначчи: 0 и 1.
//         Если N = 5 -> 0 1 1 2 3
//         Если N = 3 -> 0 1 1
//         Если N = 7 -> 0 1 1 2 3 5 8

int WriteTxtReadToInt32(string txt){
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int N = WriteTxtReadToInt32("Сколько чисел Фибоначчи выводим? - ");
int F1 = 0;
int F2 = 1;
System.Console.Write("последовательность: 0, 1");
for (int i=2; i<N; i++) {
    int F = F1 + F2;
    System.Console.Write(", " + F);
    F1 = F2; 
    F2 = F;
}
System.Console.WriteLine();

/* используя рекурсию */
int ReFibonacci(int n) {
    if (n == 1 || n == 2) return 1;
    else return ReFibonacci(n-1) + ReFibonacci(n-2);
}
for (int i=1; i<8; i++) System.Console.WriteLine($"f({i}) = {ReFibonacci(i)}");