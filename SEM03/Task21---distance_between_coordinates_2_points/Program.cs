// Задача №21. Напишите программу, которая 
//     принимает на вход координаты двух точек 
//     и находит расстояние между ними в 2D пространстве.
//         A (3,6); B (2,1) -> 5,09 
//         A (7,-5); B (1,-1) -> 7,21
//                                                     √( (x2-x1)² + (y2-y1)² )
//                                            ( (x2-x1)^2 + (y2-y1)^2 )^(1/2)
// Math.Pow(number, degree);   число в прописанной степени (число, степень)
// Math.Sqrt(squareRoot);      √ (квадратный корень) ^(1/2)
// Math.Round(variable, 5);    округление до пяти знаков после запятой

Console.Write("Первая координата первой точки = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Вторая координата первой точки = ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Первая координата второй точки = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Вторая координата второй точки = ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
distance = Math.Round(distance, 3);     // округление до определённого кол-ва знаков после запятой
Console.WriteLine("Расстояние между двумя указанными точками составляет " + distance + " у.ё.");
Console.WriteLine("Расстояние между двумя указанными точками составляет " + Math.Round( Math.Pow( Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2), 0.5), 5) + " у.ё.");