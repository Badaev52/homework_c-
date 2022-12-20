// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int numsN = inputInt("Задайте число n");
int numsM = inputInt("Задайте число m");
Console.WriteLine($" -> {fAkkerm(numsN, numsM)}");


int fAkkerm(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return fAkkerm(n - 1, 1);
    else
        return fAkkerm(n - 1, fAkkerm(n, m - 1));
}

int inputInt(string str)
{
    Console.WriteLine(str + ": ");
    bool isInt = int.TryParse(Console.ReadLine(), out int num);
    if (isInt)
    {
        if(num < 0) num = num * -1;
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число!");
        return -1;
    }

}