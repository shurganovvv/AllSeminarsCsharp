// Задача 31: 
//     Задайте массив из 12 элементов, 
//     заполненный случайными числами из промежутка [-9, 9]. 
//     Найдите сумму отрицательных и положительных элементов массива.
//         Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
//         сумма положительных чисел равна 29, 
//         сумма отрицательных равна -20.

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

int SumNegative(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i]<0) 
            result+=array[i];
    }
    return result;
}
int SumPositive(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i]>0) 
            result+=array[i];
    }
    return result;
}

int[] SumNegativeAndPositive (int[] array) {
    int[] result = new int[2];
    for (int i = 0; i < array.Length; i++) {
        if (array[i]<0) 
            result[0]+=array[i];
        else 
            result[1]+=array[i];
    }
    return result;
}

void SumNegAndPosOutV (int[] array, out int sumNegative, out int sumPositive) {
    sumNegative = 0; 
    sumPositive = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i]<0) 
            sumNegative+=array[i];
        else 
            sumPositive+=array[i];
    }
}

// int numbers = GetNumber("задайте кол-во элементов массива: ");
// int a = GetNumber("задайте минимальное число в массиве: ");
// int z = GetNumber("задайте максимальное число в массиве: ");
// int[] mas = GetArray(numbers, a, z);
int[] mas = GetArray(12, -9, 9);
PrintArray(mas);

System.Console.WriteLine();
System.Console.WriteLine($"Сумма отриц.элем.: {SumNegative(mas)}");
System.Console.WriteLine($"Сумма полож.элем.: {SumPositive(mas)}");

System.Console.WriteLine();
int[] sum = SumNegativeAndPositive(mas);
System.Console.WriteLine($"Сумма отриц.элем.: {sum[0]}");
System.Console.WriteLine($"Сумма полож.элем.: {sum[1]}");

System.Console.WriteLine();
SumNegAndPosOutV(mas, out int sumNegative, out int sumPositive);
System.Console.WriteLine($"Сумма отриц.элем.: {sumNegative}");
System.Console.WriteLine($"Сумма полож.элем.: {sumPositive}");