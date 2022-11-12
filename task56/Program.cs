// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateArray(int n, int m, int min, int max)
{
    int[,] array = new int[n, m];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]} ");
        }
        Console.WriteLine();
    }
}

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}
int n = PrintAndGetValue("Введите количество строк массива");
int m = PrintAndGetValue("Введите количество столбцов массива");
Console.WriteLine();

int[,] array = CreateArray(n, m, -5, 5);
PrintArray(array);

int minSum = int.MaxValue;
int rowMinSum = 0;

for (int i = 0; i < n; i++)
{
    int sum = 0;
    for (int j = 0; j < m; j++)
    {
        sum = sum + array[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            rowMinSum++;
        }
    }
}

Console.WriteLine("Номер строки с наименьшей суммой элементов " + rowMinSum);