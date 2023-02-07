/*Задача 43.
Напишите программу, которая найдёт точку пересечения двух прямых
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

k1 * x + b1 = k2 * x + b2
x(k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)*/

void GetPointOfIntersection(int b1, int k1, int b2, int k2)
{
    if (k1 - k2 != 0)
    {
        float x = (float)(b2 - b1) / (float)(k1 - k2);
        float y = k1 * x + b1;
        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
    else
    {
        Console.WriteLine("прямые не пересекаются или совпадают");
    }
}

int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим числа 
int b1 = GetNum("Введите число b1: ");
int k1 = GetNum("Введите число k1: ");
int b2 = GetNum("Введите число b2: ");
int k2 = GetNum("Введите число k2: ");

GetPointOfIntersection(b1, k1, b2, k2);