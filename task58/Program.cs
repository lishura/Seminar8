// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int n = PrintAndGetValue("Введите число, которое будет равно количеству столбцов первой матрицы и количеству строк второй матрицы ");
int m = PrintAndGetValue("Введите число строк первой матрицы");
int k = PrintAndGetValue("Введите число столбцов второй матрицы");

int[,] matrix1 = CreateArray(m, n, 0, 3);
int[,] matrix2 = CreateArray(n, k, 0, 3);
Console.WriteLine("Матрица 1 ");
PrintArray(matrix1);
Console.WriteLine("Матрица 2 ");
PrintArray(matrix2);

int[,] multmatrix = new int[m, k];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
   for (int j = 0; j < matrix2.GetLength(1); j++)
   {
    for (int z = 0; z < matrix2.GetLength(0); z++)
    {
        multmatrix[i,j] += matrix1[i,z]*matrix2[z,j];
    }
    
   } 
}

Console.WriteLine("Произведение матриц ");
PrintArray(multmatrix);



