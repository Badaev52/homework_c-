// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;



int[,] arr = Create2dIntArray(n);
Print2dArray(arr);

int[,] Create2dIntArray(int n)
{

    int x = 0, y = 0, size = n, count = 1;
    int[,] arr = new int[n, n];

    while (size > 0)
    {
        for (int i = y; i <= y + size - 1; i++)
        {
            arr[x, i] = count++;
        }

        for (int j = x + 1; j <= x + size - 1; j++)
        {
            arr[j, y + size - 1] = count++;
        }

        for (int i = y + size - 2; i >= y; i--)
        {
            arr[x + size - 1, i] = count++;
        }

        for (int i = x + size - 2; i >= x + 1; i--)
        {
            arr[i, y] = count++;
        }

        x = x + 1;
        y = y + 1;
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