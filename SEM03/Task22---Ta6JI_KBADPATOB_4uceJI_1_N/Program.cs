// Задача №22. Напишите программу, которая 
//     принимает на вход число (N) 
//     и выдаёт таблицу квадратов чисел от 1 до N.
//     5 -> 1, 4, 9, 16, 25.
//     2 -> 1,4

void squaresNumbers(int n)  
{
    for (double i = 1; i<n; i++) 
    {
        System.Console.Write(i * i + ", ");
    }
    System.Console.Write(n*n + ".");
}

Console.WriteLine("Давай число!");
int N = Convert.ToInt32(Console.ReadLine());
squaresNumbers(N);

//     попытка из функции (метода) сделать цикл
// void squaresNumbers(int n)  {
//     if (i <= n) {
//         i++;        System.Console.Write(i * i + ", ");        return;
//     }   else System.Console.Write(".");    // break;
// }