// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int x = 2;
int y = 2;
int z = 2;

int rndMin = 10;
int rndMax = 99;

int[,,] pointArray = Create3dIntArray(x, y, z, rndMin, rndMax);
Print3dArray(pointArray);



int[,,] Create3dIntArray(int x, int y, int z, int rndMin, int rndMax)
{

    Random random = new Random((int)(DateTime.Now.Ticks));
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {

        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {

                array[i, j, k] = random.Next(rndMin, rndMax) + 1;

            }


        }

    }

    return array;


}

void Print3dArray(int[,,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {

                Console.Write($"{arr[i, j, k]}({i}, {j}, {k})  ");


            }
            Console.WriteLine();

        }


    }

}