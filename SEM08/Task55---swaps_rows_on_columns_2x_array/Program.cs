// Задача 55: Задайте двумерный массив. Напишите программу, которая 
//     заменяет строки на столбцы. 
//                             В случае, если это невозможно, 
//                             программа должна вывести сообщение для пользователя.

int[,] GetMatrix(int rows, int cols) {
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) 
            matrix[i, j] = new Random().Next(0, 21);
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

int[,] SwapRowsOnCols(int[,] matrix) {
    int[,] swapMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++)
            swapMatrix[j,i] = matrix[i,j];
    }
    return swapMatrix;
}

var theMatrix = GetMatrix(new Random().Next(2, 5), new Random().Next(3, 7)); 
    PrintMatrix(theMatrix); 
    System.Console.WriteLine(); 

theMatrix = SwapRowsOnCols(theMatrix); 
    PrintMatrix(theMatrix); 