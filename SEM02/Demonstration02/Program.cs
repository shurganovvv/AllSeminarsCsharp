// Напишите программу, которая 
//     выводит случайное число из отрезка [10, 99] 
//     и показывает наибольшую цифру числа.
//         78 -> 8
//         12-> 2
//         85 -> 8

            System.Console.WriteLine();

int N = new Random().Next(10, 100);      // [10;100) || [10;99]
int lN = N / 10;
int rN = N % 10;
System.Console.WriteLine($"{N}: {lN} & {rN}");
if (lN > rN)
{
    System.Console.WriteLine("но Левое число больше: " + lN);
}
else if (lN < rN)
{
    System.Console.WriteLine("но Правое число больше: " + rN);
}
else { System.Console.WriteLine($"ДУБЛЬ ля: {lN} = {rN}"); }

            System.Console.WriteLine();

Random rend = new Random();
int number = rend.Next(10, 100);
System.Console.WriteLine("Cлучайное число: " + number);

int leftNumber = number / 10;
int rightNumber = number % 10;
System.Console.WriteLine($"{leftNumber} {rightNumber}");

if (leftNumber > rightNumber)
{
    System.Console.WriteLine("Левое число больше: " + leftNumber);
}
else if (leftNumber < rightNumber)
{
    System.Console.WriteLine("Правое число больше: " + rightNumber);
}
else { System.Console.WriteLine("Числа равны"); }

            System.Console.WriteLine();

// действия можно прописывать в условиях (вместо переменных)