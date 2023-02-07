/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int PositiveNumbers(int[] intArray)
{
    int count = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] GetArrayFromConsole(int length)
{
    int[] arrayNum = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        arrayNum[i] = int.Parse(Console.ReadLine());
    }
    return arrayNum;
}

int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Запросим сколько чисел вводить 
int lengthNum = GetNum("Введите количество чисел: ");

// Ввод самих чисел
int[] numArray = GetArrayFromConsole(lengthNum);

// Считаем сколько положительных чисел
int countPositiv = PositiveNumbers(numArray);

Console.Write($"[{String.Join(" ,", numArray)}] -> {countPositiv}");

