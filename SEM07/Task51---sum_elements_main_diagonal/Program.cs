// Задача 51: Задайте двумерный массив. 
//     Найдите сумму элементов, находящихся на главной диагонали 
//         (с индексами (0,0); (1;1) и т.д.)
//             Например, задан массив:
//                 1 4 7 2
//                 5 9 2 3
//                 8 4 2 4
//             Сумма элементов главной диагонали: 1+9+2 = 12

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

// int SumMainDiagonal(int[,] matrix) {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++) {
//         for (int j = 0; j < matrix.GetLength(1); j++) {
//             if (i == j) 
//                 sum += matrix[i,j];
//         }
//     }
//     return sum;
// }            сократили скрипт: 
int SumMainDiagonal(int[,] matrix) {
    int sum = 0;
    // int lengthEnd;
    // if (matrix.GetLength(0) > matrix.GetLength(1))
    //     lengthEnd = matrix.GetLength(1);
    // else lengthEnd = matrix.GetLength(0);
	//                                                  с ТЕРНАРНЫМ оператором: 
    int lengthEnd = ( matrix.GetLength(0) > matrix.GetLength(1) ) ? matrix.GetLength(1) : matrix.GetLength(0);
    for (int i = 0; i < lengthEnd; i++) {
        sum += matrix[i,i];
    }
    return sum;
}                                       // наверно самое ОПТИМАЛЬНОЕ РЕШЕНИЕ от студня:
// int SumMainDiagonal(int[,] matrix) {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++) {
//         sum += matrix[i,i];
//     }
//     return sum;
// }

int rows = WriteTxtReadToInt32("Введите количество строк Матрицы: ");
int cols = WriteTxtReadToInt32("Введите количество столбцов Матрицы: ");
var theMatrix = GetMatrix(rows, cols);
    PrintMatrix(theMatrix);
System.Console.WriteLine($"Сумма элементов главной диагонали = {SumMainDiagonal(theMatrix)}");