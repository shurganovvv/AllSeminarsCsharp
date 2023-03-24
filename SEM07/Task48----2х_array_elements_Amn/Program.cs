// Задача 48: Задайте двумерный массив размера m на n, 
//     каждый элемент в массиве находится по формуле: Amn = m+n. 
//     Выведите полученный массив на экран.
//         rows = 3, cols = 4.
//             0 1 2 3
//             1 2 3 4
//             2 3 4 5

int WriteTxtReadToInt32(string txt) {
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int cols) {
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = i + j;
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

int rows = WriteTxtReadToInt32("Введите количество строк Матрицы: ");
int cols = WriteTxtReadToInt32("Введите количество столбцов Матрицы: ");
System.Console.WriteLine();
var theMatrix = GetMatrix(rows, cols);
PrintMatrix(theMatrix);