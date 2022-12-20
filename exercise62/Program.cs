// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 5;



int[,] arr = Create2dIntArray(n);
Print2dArray(arr);

int[,] Create2dIntArray(int n)
{

    int row = 0, col = 0, size = n, count = 1;
    int[,] arr = new int[n, n];

    while (size > 0)
    {
        for (int i = col; i <= col + size - 1; i++)
        {
            arr[row, i] = count++;
        }

        for (int j = row + 1; j <= row + size - 1; j++)
        {
            arr[j, col + size - 1] = count++;
        }

        for (int i = col + size - 2; i >= col; i--)
        {
            arr[row + size - 1, i] = count++;
        }

        for (int i = row + size - 2; i >= row + 1; i--)
        {
            arr[i, col] = count++;
        }

        row = row + 1;
        col = col + 1;
        size = size - 2;
    }
    return arr;

}

void Print2dArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write(string.Format("{0:d2}", arr[i, j]));
            Console.Write('\t');

        }
        Console.WriteLine();

    }

}