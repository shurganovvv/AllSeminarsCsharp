// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая 
//     удалит строку и столбец, 
//         на пересечении которых расположен первый наименьший элемент массива.
//             Например, задан массив:
//                 1 4 7 2
//                 5 9 2 3
//                 8 4 2 4
//                 5 2 6 7
//             Наименьший элемент - 1, на выходе получим следующий массив:
//                 9 2 3
//                 4 2 4
//                 2 6 7

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

// int[,] ChangeMatrix(int[,] matrix)
// {
//     int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 matrix2[j,i] = matrix[i,j];
//             }
//     }
//     return matrix2;
// }

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


void FindMin(int[,] matrix, out int minI, out int minJ) {
    minI = 0;
    minJ = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if (matrix[i, j] < min) {
                min = matrix[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
}

int[,] GenerateNewMatrix(int[,] matrix, int Imin, int Jmin) {
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int newi = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
        if (i != Imin) {
            int newj = 0;
            for (int j = 0; j < matrix.GetLength(1); j++) {
                if (j != Jmin) {
                    newMatrix[newi, newj] = matrix[i, j];
                    newj++;
                }
            }
            newi++;
        }
    }
    return newMatrix;
}

var theMatrix = GetMatrix(new Random().Next(1, 5), new Random().Next(3, 7)); 
    PrintMatrix(theMatrix); 
    System.Console.WriteLine(); 
// myMatrix = ChangeMatrix(myMatrix);
FindMin(theMatrix, out int minI, out int minJ);
System.Console.WriteLine();
System.Console.WriteLine("Новая матрийа:");
PrintMatrix(GenerateNewMatrix(theMatrix, minI, minJ)); 