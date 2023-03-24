// Задача 32: Напишите программу замены элементов массива: 
//     положительные элементы замените на соответствующие отрицательные, 
//     и наоборот.
//         [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int GetNumber(string txt) {    System.Console.Write(txt);    return Convert.ToInt32(Console.ReadLine()); }

int[] GetArray(int sise, int min, int max) {
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[] array) {
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int[] Replacing (int[] array) {
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
    return array;
}

void ReplacingVoid (int[] array) {
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
}

// int numbers = GetNumber("задайте кол-во элементов массива: ");
// int a = GetNumber("задайте минимальное число в массиве: ");
// int z = GetNumber("задайте максимальное число в массиве: ");
// int[] mas = GetArray(numbers, a, z);
int[] mas = GetArray(7, -9, 9);
PrintArray(mas);

mas = Replacing(mas); //меняем с момощью возврата массива
PrintArray(mas);

ReplacingVoid(mas); //меняем (ещё раз) с момощью void
PrintArray(mas);