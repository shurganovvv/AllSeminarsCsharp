// Задача 35: Задайте одномерный 
//     массив из 123 случайных чисел. 
//     Найдите количество элементов массива, 
//         значения которых лежат в отрезке [10,99]. 
//             Пример для массива из 5, а не 123 элементов. 
//                 В своём решении сделайте для 123
//             [5, 18, 123, 6, 2] -> 1
//             [1, 2, 3, 6, 2] -> 0
//             [10, 11, 12, 13, 14] -> 5
// Задайте одномерный массив из 12 случайных чисел в промежутке [-99;99]. 
//     Найдите количество элементов массива, 
//         значения которых лежат в отрезке [10,99]. 
            
int[] GetArray(int sise, int min, int max) {
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[] array) {
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int NubberElements (int[] array) {
    int nubbers = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] >= 10 && array[i] <= 99) 
            nubbers++;
    }
    return nubbers;
}

int[] mas = GetArray(12, -99, 99);
PrintArray(mas);

System.Console.WriteLine(NubberElements(mas));