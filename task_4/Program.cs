/*
Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
Напишите программу, которая будет построчно выводить массив. 
Обратите внимание, что максимальный размер такого массива ограничен. 
Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.

Например,
11 22 78
12 47 96
25 87 88
*/
void FillArray(ref int[,] arr, int m, int n){
    int num = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int count = 0; arr[i,j] == 0 && count<=88; count++){
                if (!IfIssetInArray(num = new Random().Next(10, 99), arr)) {
                    arr[i,j] = num;
                }
            }       
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

bool IfIssetInArray(int num, int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == num){
                return true;
            }
        }
    }
    return false;
}

int m = 9;
int n = 9;

if ((m*n)<=88){
    Console.WriteLine("Создаем произвольный двумерный массив, например " + m + " x " + n);

    int [,] matrix = new int[m,n];

    FillArray(ref matrix, m, n);

    PrintArray(matrix);
}else{
    Console.WriteLine("Количество элементов превышает допустимое");
}




