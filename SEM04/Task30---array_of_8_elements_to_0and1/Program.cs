// Задача 30: Напишите программу, которая 
//     выводит массив из 8 элементов, 
//         заполненный нулями и единицами 
//             в случайном порядке.
//     [1,0,1,1,0,1,0,0]
//                        string.Join("разделитель", имя_массива);

void GetArray(int[] array)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(0, 2);
}

int[] myArray = new int[8];
GetArray(myArray);
System.Console.WriteLine($"[{string.Join(", ", myArray)}]");



void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
        System.Console.Write(array[i] + " ");
}

int[] FillArrayRandom(int sise)
{
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(0, 2);
    return array;
}

int[] mas = FillArrayRandom(8);
PrintArray(mas);