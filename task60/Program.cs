// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,,] CreateArray3D(int size1, int size2, int size3)
{
    int[,,] array3D = new int[size1, size2, size3];
    int[] tempArray = new int[size1 * size2 * size3];
    int number = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(10, 100);
        number = tempArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 100);
                    j = 0;
                    number = tempArray[i];
                }
                number = tempArray[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < size1; x++)
    {
        for (int y = 0; y < size2; y++)
        {
            for (int z = 0; z < size3; z++)
            {
                array3D[x, y, z] = tempArray[count];
                count++;
            }
        }
    }

    return array3D;
}

void PrintArray3D (int [,,]array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            for (int deep = 0; deep < array.GetLength(2); deep++)
                Console.Write($"{array[row, col, deep]}({row},{col},{deep}) ");
        }
        Console.WriteLine();
    }
}

int size1 = PrintAndGetValue("Введите размерность 1 ");
int size2 = PrintAndGetValue("Введите размерность 2 ");
int size3 = PrintAndGetValue("Введите размерность 3 ");

int [,,] array3D = CreateArray3D(size1, size2, size3);
PrintArray3D(array3D);