// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

EnteringCoefficients(out double b1, out double k1, out double b2, out double k2);
var point = PointOfIntersectionOfLines(b1, k1, b2, k2);

Console.WriteLine($"Координаты точки пересечения x = {point.Item1}, y = {point.Item2}");

(double, double) PointOfIntersectionOfLines(double b1, double k1, double b2, double k2)
{

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    var res = (x, y);

    return res;

}

void EnteringCoefficients(out double b1, out double k1, out double b2, out double k2)
{
    b1 = InputDouble("Задайте коэффициент b1");
    k1 = InputDouble("Задайте коэффициент k1");
    b2 = InputDouble("Задайте коэффициент b2");
    k2 = InputDouble("Задайте коэффициент k2");
}

double InputDouble(string str)
{
    Console.WriteLine(str + ": ");
    bool isInt = double.TryParse(Console.ReadLine(), out double num);
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

