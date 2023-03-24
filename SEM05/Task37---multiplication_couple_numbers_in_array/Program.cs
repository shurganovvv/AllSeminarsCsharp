// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//     Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
//     [1 2 3 4 5] -> 5 8 3
//     [6 7 3 6] -> 36 21

int[] GetArray(int sise, int min, int max) {
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[] array) {
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int[] MultiplicationCoupleNumbers  (int[] array) {
    int halfSize;
    if (array.Length % 2 == 0)
        halfSize = array.Length / 2;
    else
        halfSize = array.Length / 2 + 1;
    // int halfSize = array.Length /2 + array.Length %2; // вместо условия выше
    int[] multiNum = new int[halfSize];

    for (int i = 0; i < halfSize; i++)
        multiNum[i] = array[i] * array[array.Length - i-1];
    
    if (array.Length %2 != 0)
        multiNum[multiNum.Length-1] = array[halfSize-1];

    return multiNum;
}

int[] mas = GetArray(7, -9, 9);
PrintArray(mas);
int[] multiCoupleMas = MultiplicationCoupleNumbers(mas);
PrintArray(multiCoupleMas);