// Задача №18. Напишите программу, которая 
//     по заданному номеру четверти, 
//         показывает диапазон возможных координат точек в этой четверти 
//             (x и y).

void CoordinateRange(int XY)
{
    if (XY == 1)
    {
        System.Console.WriteLine("Четверть находится в правой верхней плоскости.");
        System.Console.WriteLine("Координаты точеки: " + coordinatePlane[1]);
    }
    else if (XY == 2)
    {
        System.Console.WriteLine("Четверть находится в левой верхней плоскости.");
        System.Console.WriteLine("Координаты точеки: " + coordinatePlane[2]);
    }
    else if (XY == 3)
    {
        System.Console.WriteLine("Четверть находится в левой нижней плоскости.");
        System.Console.WriteLine("Координаты точеки: " + coordinatePlane[3]);
    }
    else if (XY == 4)
    {
        System.Console.WriteLine("Четверть находится в правой нижней плоскости.");
        System.Console.WriteLine("Координаты точеки: " + coordinatePlane[4]);
    }
    else
    {
        System.Console.WriteLine(coordinatePlane[0]);
    }
}

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());
string[] coordinatePlane = { "Нет такой четверти!", "x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0" };
CoordinateRange(quarter);