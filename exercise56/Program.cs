// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int row = 5;
int col = 6;
int rndMin = 0;
int rndMax = 100;

int[,] arr = Create2dIntArray(row, col, rndMin, rndMax);
Print2dArray(arr);
int[] sumRowArray = SumRow2dArray(arr);
PrintArray(sumRowArray);
int rowMinSum = FindingMinimumNumberRow(sumRowArray);
Console.WriteLine($"Минимальная сумма элементов в строке {rowMinSum}");


int FindingMinimumNumberRow(int[] arr)
{
    int min = arr[0];
    int minInd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) {
            
            min = arr[i];
            minInd = i;

        }

    }


    return minInd + 1;

}

int[] SumRow2dArray(int[,] arr)
{

    int[] rowSumArray = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {

            sum = sum + arr[i, j];

        }

        rowSumArray[i] = sum;

    }

    return rowSumArray;

}


int[,] Create2dIntArray(int row, int col, int min, int max)
{
    Random random = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {

        for (int j = 0; j < col; j++)
        {

            array[i, j] = random.Next(min, max) + 1;

        }

    }

    return array;

}

void Print2dArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write(arr[i, j]);
            Console.Write('\t');

        }
        Console.WriteLine();

    }

}

void PrintArray(int[] arr)
{
    Console.Write("Массив сумм по строкам: ");
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write(arr[i]);
        if (i == arr.Length - 1) break;
        Console.Write(",  ");
    }
    Console.WriteLine();
}