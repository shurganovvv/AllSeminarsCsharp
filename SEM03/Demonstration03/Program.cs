// Задача №17. Напишите программу, которая 
//     принимает на вход координаты точки (X и Y), 
//         причем X ≠ 0 и Y ≠ 0 
//     и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координаты через Enter");
Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату У");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в правой верхней плоскости.");
    System.Console.WriteLine("Номер четверти: 1");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в левой верхней плоскости.");
    System.Console.WriteLine("Номер четверти: 2");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в левой нижней плоскости.");
    System.Console.WriteLine("Номер четверти: 3");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в правой нижней плоскости.");
    System.Console.WriteLine("Номер четверти: 4");
}
else
{
    System.Console.WriteLine("Точка точка лежит в начале координат.");
}



int InputNumber(string str) // string, bool, int[], double[], string[], void ...
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

void FindQuarter(int a, int b)
{
    if (a > 0 && b > 0)
    {
        System.Console.WriteLine("Точка находится в правой верхней плоскости.");
        System.Console.WriteLine("Номер четверти: 1");
    }
    else if (a < 0 && b > 0)
    {
        System.Console.WriteLine("Точка находится в левой верхней плоскости.");
        System.Console.WriteLine("Номер четверти: 2");
    }
    else if (a < 0 && b < 0)
    {
        System.Console.WriteLine("Точка находится в левой нижней плоскости.");
        System.Console.WriteLine("Номер четверти: 3");
    }
    else if (a > 0 && b < 0)
    {
        System.Console.WriteLine("Точка находится в правой нижней плоскости.");
        System.Console.WriteLine("Номер четверти: 4");
    }
    else
    {
        System.Console.WriteLine("Точка точка лежит в начале координат.");
    }
}

int X = InputNumber("Введите координату Х");
int Y = InputNumber("Введите координату У");
FindQuarter(X, Y);

// возможны одинаковые имена переменных