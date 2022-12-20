// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int numsM = inputInt("Задайте число М");
int numsN = inputInt("Задайте число N");
Console.WriteLine($" -> {PrintNaturalNumberReqursive(numsM, numsN)}");

int PrintNaturalNumberReqursive(int interval0, int interval1)
{

    if (interval0 > interval1)
    {
        int temp = interval0;
        interval0 = interval1;
        interval1 = temp;
    }

    return (interval0 == interval1) ? interval1 : interval0 + PrintNaturalNumberReqursive(interval0 + 1, interval1);


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