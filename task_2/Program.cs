/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int findMinSumRow(ref int[,] arr){
    int maxSum = 0;
    int numRow = 0;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i,j];
        }
        
        if (sum > maxSum)
        {
            maxSum = sum;
            numRow = i+1;
        }
    }

    return numRow;
}

int m = 4;
int n = 4;

Console.WriteLine("Создаем произвольный двумерный массив, например " + m + " x " + n);

int [,] matrix = new int[m,n];

fillArray(ref matrix, m, n);
printArray(matrix);
Console.WriteLine();
Console.WriteLine(findMinSumRow(ref matrix));

