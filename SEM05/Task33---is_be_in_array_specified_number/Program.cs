// Задача 33: Задайте массив. Напишите программу, которая 
//     определяет, присутствует ли заданное число в массиве.
//         4; массив [6, 7, 19, 345, 3] -> нет
//         -3; массив [6, 7, 19, 345, -3] -> да

int GetNumber(string txt) {    
    System.Console.Write(txt);    
    return Convert.ToInt32(Console.ReadLine()); 
}

int[] GetArray(int sise, int min, int max) {
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[] array) {
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

bool FindNumber (int[] array, int number) {
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == number) 
            return true;
    }
    return false;
}

void FindNumberVoid (int[] array, int number) {
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == number) {
            System.Console.WriteLine("такое чисто в наличии");
            return;
        }
    }
    System.Console.WriteLine("такого чиста нема");
}

// int numbers = GetNumber("задайте кол-во элементов массива: ");
// int a = GetNumber("задайте минимальное число в массиве: ");
// int z = GetNumber("задайте максимальное число в массиве: ");
// int[] mas = GetArray(numbers, a, z);
int[] mas = GetArray(12, 0, 9);
int specified = GetNumber("задайте число, которое нужно найти: ");
PrintArray(mas);
if (FindNumber(mas, specified))
    System.Console.WriteLine("есть такой элемент");
else 
    System.Console.WriteLine("нет такого элемента");

FindNumberVoid(mas, specified); 

System.Console.WriteLine(Array.IndexOf(mas, specified)); 
//выводит первый индекс указанного элемента 'specified' в массиве 'mas'