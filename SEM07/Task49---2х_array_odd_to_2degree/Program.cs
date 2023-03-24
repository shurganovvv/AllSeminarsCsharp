// Задача 49: Задайте двумерный массив. 
//     Найдите элементы, у которых оба индекса нечётные, 
//     и замените эти элементы на их квадраты.
//         Например, изначально массив выглядел вот так:
//             1 4 7 2
//             5 9 2 4
//             8 4 2 3
//         Новый массив будет выглядеть вот так:
//             1 4 7 2
//             5 81 2 16
//             8 4 2 3

int WriteTxtReadToInt32(string txt) {
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int cols) {
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = new Random().Next(0, 21);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// void SpecialOddToSquare(int[,] matrix) {
//     for (int i = 0; i < matrix.GetLength(0); i++) {
//         for (int j = 0; j < matrix.GetLength(1); j++) {
//             if (i % 2 != 0 && j % 2 != 0) matrix[i,j]*=matrix[i,j];
//         }
//     }
// }            сократили скрипт: 
void SpecialOddToSquare(int[,] matrix) {
    for (int i = 1; i < matrix.GetLength(0); i+=2) {
        for (int j = 1; j < matrix.GetLength(1); j+=2)
            matrix[i,j]*=matrix[i,j];
    }
}

int rows = WriteTxtReadToInt32("Введите количество строк Матрицы: ");
int cols = WriteTxtReadToInt32("Введите количество столбцов Матрицы: ");
var theMatrix = GetMatrix(rows, cols);
    PrintMatrix(theMatrix);
    System.Console.WriteLine();

SpecialOddToSquare(theMatrix);
    PrintMatrix(theMatrix);
    System.Console.WriteLine();