/*
Задача 3: Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18
*/



void FillArray(ref int[,] arr, int m, int n){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();  
    }
}

int[,] FindMatrixProduct(int[,] arr1, int[,] arr2){

    int m = arr1.GetLength(0);
    int n = arr1.GetLength(1);
    int[,] resultArray = new int[m,n];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int k = 0; k < resultArray.GetLength(0); k++){
                resultArray[i,j] += arr1[i,k]*arr2[k,j];
            }
        }
    }

    return resultArray;
}

int m = 3;
int n = 3;

Console.WriteLine("Создаем две одинаковые двумерные матрицы для перемножения, например " + m + " x " + n);

int [,] matrix1 = new int[m,n];
int [,] matrix2 = new int[m,n];

FillArray(ref matrix1, m, n);
FillArray(ref matrix2, m, n);
Console.WriteLine();
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(FindMatrixProduct(matrix1, matrix2));