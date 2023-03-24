// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
//     Набор данных        { 1, 9, 9, 0, 2, 8, 0, 9 }
//     Частотный массив    0 встречается 2 раза 
//                         1 встречается 1 раз 
//                         2 встречается 1 раз 
//                         8 встречается 1 раз 
//                         9 встречается 3 раза
//     Набор данных        1, 2, 3 
//                         4, 6, 1 
//                         2, 1, 6
//     Частотный массив    1 встречается 3 раза 
//                         2 встречается 2 раз 
//                         3 встречается 1 раз 
//                         4 встречается 1 раз 
//                         6 встречается 2 раза

int[,] GetMatrix(int rows, int cols) {
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            matrix[i, j] = new Random().Next(0, 10);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            System.Console.Write(matrix[i,j] + "\t");
        System.Console.WriteLine();
    }
}

void Chastota(int[,] matrix) {
    for (int l = 0; l < 10; l++) {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (l == matrix[i, j]) count++;
        }
        if (count > 0)
            System.Console.WriteLine($"{l} встречаетмя {count} раз");
    }
}

int[] ChastotaVmas(int[,] matrix) {
    var count = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            count[matrix[i, j]]++; 
    }
    return count; 
}

void PrintData(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        if (array[i] != 0)
            System.Console.WriteLine($"{i} значение встречается {array[i]} раз"); 
    }
}

var theMatrix = GetMatrix(new Random().Next(1, 5), new Random().Next(3, 7)); 
    PrintMatrix(theMatrix); 
    System.Console.WriteLine(); 
Chastota(theMatrix); 
    System.Console.WriteLine(); 
PrintData(ChastotaVmas(theMatrix)); //Семинар 08. Двумерные массивы. Продолжение - 1:22
    System.Console.WriteLine(); 




//Семинар 08. Двумерные массивы. Продолжение - 1:30

int[] OverWriteInArray(int[,] matrix) {
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}

void GetResult(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == 0)
            count++;
    }
    System.Console.WriteLine($"Число 0 встречается {count} раз");

    int number = 0;
    for (int i = 0; i < array.Length; i++) {
        number = array[i];
        count = 0;
        if (number == 0) {
            continue;
        }
        for (int j = 0; j < array.Length; j++) {
            if (array[j] == number) {
                count++;
                array[j] = 0;
            }
        }
        System.Console.WriteLine($"Число {number} встречается {count} раз");
    }
}


GetResult(OverWriteInArray(theMatrix)); 