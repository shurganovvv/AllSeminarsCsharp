// Задача 26: Напишите программу, которая 
//     принимает на вход число и 
//     выдаёт количество цифр в числе.
//         456 -> 3
//         78 -> 2
//         89126 -> 5

string GetStrNumber(string txt)
{
    System.Console.Write(txt);
    return Console.ReadLine();
    // return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int AbsLen(string txt) {
    txt = Convert.ToString(Math.Abs(Convert.ToInt32(txt)));
    System.Console.WriteLine(txt);
    int len = txt.Length;
    return len;
}

string a = GetStrNumber("Принимаю на вход число: ");
System.Console.WriteLine($"Число {a} содержит {AbsLen(a)} цифр");
// int len = a.Length;
// System.Console.WriteLine($"Число содержит {len} цифр");

/* математика: 

int GetIntNumber(string txt)
{
    System.Console.Write(txt);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Numbers(int A) {
    A = Math.Abs(A);
    int numbers = 1;
    while (A / 10 > 0) { A = A / 10; numbers++; }
    return numbers;
}

int a = GetntNumber("Принимаю на вход число: ");
System.Console.WriteLine($"Число {a} содержит {Numbers(a)} цифр");
*/