// Задача 24: Напишите программу, которая 
//     принимает на вход число (А) 
//     и выдаёт сумму чисел от 1 до А.
//         7 -> 28
//         4 -> 10
//         8 -> 36

int GetNumber(string txt)
{
    System.Console.Write(txt);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int GetSumElements(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++) sum += i;
    return sum;
}

int num = GetNumber("Принимаю на вход число А: ");
if (num == 0) System.Console.WriteLine($"сумму чисел от 1 до 0 = 1");
else System.Console.WriteLine($"сумму чисел от 1 до {num} = {GetSumElements(num)}");

/*
Console.Write("Принимаю на вход число А: ");
int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (A == 0) System.Console.WriteLine($"сумму чисел от 1 до 0 = 1");
else {
    int sum = 0;
    for (int i = 1; i <= A; i++) sum += i;
    System.Console.WriteLine($"сумму чисел от 1 до {A} = {sum}");
}
*/