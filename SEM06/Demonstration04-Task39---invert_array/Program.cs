// Задача 39: Напишите программу, которая 
//     перевернёт одномерный массив 
//         (последний элемент будет на первом месте, 
//         а первый - на последнем и т.д.)
//             [1 2 3 4 5] -> [5 4 3 2 1]
//             [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int sise, int min, int max) {
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[] array) {
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

void ReverseArray (int[] array) {
    int temp;
    for (int i = 0; i < array.Length/2; i++) {
        temp = array[i];
        array[i] = array[array.Length - i-1];
        array[array.Length - i-1] = temp;
    }
}

int[] mas = GetArray(7, 0, 10);
    PrintArray(mas);

ReverseArray(mas);
    PrintArray(mas);

Array.Reverse(mas);
    PrintArray(mas);