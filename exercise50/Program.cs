// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


double[,] arr = Create2dDoubleArray(3, 4, -10.0, 10.0);
Print2dArray(arr);
int row = inputInt("Задайте номер строки ");
int col = inputInt("Задайте номер колонки ");
searchForAnArrayElement(arr, row, col);

void searchForAnArrayElement(double[,] arr, int row, int col)
{

    if (row > arr.GetLength(0) || col > arr.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве не существует");
    }
    else
    {
        Console.WriteLine($"Элемент поз.({row}, {col}) равен: {string.Format("{0:F1}", arr[row - 1, col - 1])}");

    }

}

int inputInt(string str)
{
    Console.WriteLine(str + ": ");
    bool isInt = int.TryParse(Console.ReadLine(), out int num);
    if (isInt)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число!");
        return -1;
    }

}

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
