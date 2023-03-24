// Задача №3. Напишите программу, которая будет 
//      выдавать название дня недели по заданному номеру.
//          3 -> Среда 
//          5 -> Пятница


Console.WriteLine("Вас приветствует Нанедельник посещений.");
Console.WriteLine("На день надели Вы хотели бы записаться?");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("на Понедельник записи нет");
        break;
    case 2:
        Console.WriteLine("на Вторник записи нет");
        break;
    case 3:
        Console.WriteLine("на Среду записи нет");
        break;
    case 4:
        Console.WriteLine("на Чесверг записи нет");
        break;
    case 5:
        Console.WriteLine("на Пятницу записи нет");
        break;
    case 6:
        Console.WriteLine("Суббота - выходной");
        break;
    case 7:
        Console.WriteLine("Воскресенье - выходной");
        break;
    default:
        System.Console.WriteLine("в отпуске");
        break;
}

/*
if (day == 1)
{
    Console.WriteLine("на Понедельник записи нет");
}
else if (day == 2)
{
    Console.WriteLine("на Вторник записи нет");
}
else if (day == 3)
{
    Console.WriteLine("на Среду записи нет");
}
else if (day == 4)
{
    Console.WriteLine("на Четверг записи нет");
}
else if (day == 5)
{
    Console.WriteLine("на Пятницу записи нет");
}
else if (day == 6)
{
    Console.WriteLine("Суббота - выходной");
}
else if (day == 7)
{
    Console.WriteLine("Воскресенье - выходной");
}
else
{
    Console.WriteLine("заклятье временного расширения временно не работает");
}
*/
