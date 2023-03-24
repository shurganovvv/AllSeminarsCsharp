// Задача №7. Напишите программу, которая 
//     принимает на вход трёхзначное число 
//     и на выходе показывает последнюю цифру этого числа.
//   	    456 -> 6
//       	782 -> 2
//   	    918 -> 8

Console.WriteLine("Вводи, не стесняйся");
int number = Convert.ToInt32(Console.ReadLine());
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99 && number < 1000)
{
    // int lastDigit = number % 10;
    System.Console.WriteLine(number % 10);
}
else if (number < -99 && number > -1000)
{
    // int lastDigit = (number % 10) * -1;
    System.Console.WriteLine(-1 * number % 10);
}
else
{
    System.Console.WriteLine("нет-нет - по условиям задачи вводить нужно только трёхзначное число");
}