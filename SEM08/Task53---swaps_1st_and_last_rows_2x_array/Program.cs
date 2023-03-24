// Задача 53: Задайте двумерный массив. Напишите программу, которая 
//     поменяет местами первую и последнюю строку массива.

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

void SwapFirstLastRows(int[,] matrix) {
    int temp;
    for (int j = 0; j < matrix.GetLength(1); j++) {
        temp = matrix[0, j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = temp;
    }   
}

var theMatrix = GetMatrix(new Random().Next(2, 5), new Random().Next(3, 7)); 
    PrintMatrix(theMatrix); 
    System.Console.WriteLine(); 
SwapFirstLastRows(theMatrix); 
    PrintMatrix(theMatrix); 