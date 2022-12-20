// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int row = 3;
int col = 3;
int rndMin = 0;
int rndMax = 100;

int[,] arr1 = Create2dIntArray(row, col, rndMin, rndMax);
Print2dArray(arr1);
Console.WriteLine("--------------");
int[,] arr2 = Create2dIntArray(row, col, rndMin, rndMax);
Print2dArray(arr2);
Console.WriteLine("Результат умножения матрицы 1 на матрицу 2:");
int[,] arr = MatrixMultiplication(arr1, arr2);
Print2dArray(arr);


int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{

    int[,] arr = new int[arr1.GetLength(0), arr1.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {

        for (int j = 0; j < arr1.GetLength(1); j++)
        {

            arr[i, j] = arr1[i, j] * arr2[i, j];

        }


    }

    return arr;
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