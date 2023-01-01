/*Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void fillArray(ref int[,] arr, int m, int n){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = new Random().Next(0, 10);
        }
    }
}

void printArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();  
    }
}

void sortArray(ref int[,] arr){
    
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int i = 0; i < arr.GetLength(1)-1; i++)
        {
            for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            if (arr[m,j] > arr[m,j+1]){
                int tmp = arr[m,j];
                arr[m,j] = arr[m,j+1];
                arr[m,j+1] = tmp;
            }
        }
        }
    }
}

int m = 4;
int n = 4;

Console.WriteLine("Создаем произвольный двумерный массив, например " + m + " x " + n);

int [,] matrix = new int[m,n];

fillArray(ref matrix, m, n);
printArray(matrix);
Console.WriteLine();
sortArray(ref matrix);
printArray(matrix);
