// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int nums = inputInt("Задайте количество чисел ");

int[] inpNumb = CountQuantityPositiveNumbers(nums, out int posNumb);
PrintArray(inpNumb);
Console.WriteLine($"Количество положительных чисел: {posNumb}");

int[] CountQuantityPositiveNumbers(int count, out int res)
{
    res = 0;
    int[] inputNumbers = new int[count];

    for (int i = 0; i < count; i++)
    {
        string str = $"Введите число {i + 1} из {count}";
        int temp = inputInt(str);
        inputNumbers[i] = temp;

        if (temp > 0) res++;

    }

    return inputNumbers;
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

void PrintArray(int[] arr)
{
    Console.Write("Вы ввели: ");
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write(arr[i]);
        if (i == arr.Length - 1) break;
        Console.Write(", ");
    }
    Console.WriteLine();
}
