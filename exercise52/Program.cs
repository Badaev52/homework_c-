// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] arr = Create2dIntArray(3, 4, 0, 10);
Print2dArray(arr);
double[] arrAvr = AverageCol(arr);
PrintArray(arrAvr);

void PrintArray(double[] arr)
{
    Console.Write("Среднее арифметическое по столбцам: ");
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write(string.Format("{0:F1}", arr[i]));
        if (i == arr.Length - 1) break;
        Console.Write(",  ");
    }
    Console.WriteLine();
}

double[] AverageCol(int[,] array)
{

    double[] avr = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {

            temp = temp + array[i, j];


        }
        avr[j] = temp / array.GetLength(0);

    }
    return avr;
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
