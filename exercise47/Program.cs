// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4
// 0,5      7       -2      -0,2
// 1        -3,3    8       -9,9
// 8        7,8     -7,1    9

double[,] arr = Create2dDoubleArray(3, 4, -10.0, 10.0);
Print2dArray(arr);


double[,] Create2dDoubleArray(int row, int col, double min, double max)
{
    Random random = new Random();
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {

        for (int j = 0; j < col; j++)
        {

            array[i, j] = min + (random.NextDouble() * (max - min));

        }

    }

    return array;

}

void Print2dArray(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write(string.Format("{0:F1}", arr[i, j]));
            Console.Write('\t');

        }
        Console.WriteLine();

    }


}