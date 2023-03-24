// Задача 46: Задайте двумерный массив размером m×n, 
//     заполненный случайными целыми числами.
//         m = 3, n = 4.
//             1 4 8 19
//             5 -2 33 -2
//             77 3 8 1

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

int rows = WriteTxtReadToInt32("Введите количество строк Матрицы: ");
int cols = WriteTxtReadToInt32("Введите количество столбцов Матрицы: ");
System.Console.WriteLine();
var theMatrix = GetMatrix(rows, cols);
PrintMatrix(theMatrix);