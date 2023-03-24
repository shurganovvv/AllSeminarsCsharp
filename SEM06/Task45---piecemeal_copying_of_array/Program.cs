//  Задача 45: Напишите программу, которая 
//     будет создавать копию заданного массива 
//         с помощью поэлементного копирования.

int WriteTxtReadToInt32(string txt){
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

int[] CopyingArray(int[] array) {
    int[] copyOfArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++) {
        copyOfArray[i] = array[i];
    }
    return copyOfArray;
}

int[] mas = GetArray(7, 0, 10);
    PrintArray(mas);
int[] copied = CopyingArray(mas);
    PrintArray(copied);
int[] noCopy = mas; // ссылается на одни ячейки памяти: меняя один изменим другой (и наоборот)
int[] copy = mas[..]; // создаётся копия