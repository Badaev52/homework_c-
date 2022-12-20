// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int N = 8;
PrintNaturalNumberReqursive(N);

void PrintNaturalNumberReqursive(int N){

    int num0 = 1;

    if(N > num0){
        Console.Write($"{N}, ");
        PrintNaturalNumberReqursive(N - 1);
    }else if(N == num0){
        Console.Write(num0);
    }


}
