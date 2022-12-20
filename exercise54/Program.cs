// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int row = 5;
int col = 6;
int rndMin = 0;
int rndMax = 100;

int[,] arr = Create2dIntArray(row, col, rndMin, rndMax);
Print2dArray(arr);
BubleSortRow2dArray(arr);
Console.WriteLine("--------------");
Print2dArray(arr);


void BubleSortRow2dArray(int[,] arr)
{

    for (int row = 0; row < arr.GetLength(0); row++)
    {


        for (int i = 0; i < arr.GetLength(1); i++)
        {

            for (int j = 0; j < arr.GetLength(1) - 1 - i; j++)
            {

                if (arr[row,j] < arr[row, (j + 1)])
                {

                    SwapAB(ref arr[row, j], ref arr[row, (j + 1)]);
                }
            }
        }

    }

}


void SwapAB(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
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
