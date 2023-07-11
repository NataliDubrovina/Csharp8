/*Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = RandomValue(matrix, i, j, k); 
        }
    }
}

static int RandomValue(int[,,] matrix, int i, int j, int k)
{
    int value = default;
    bool flag = true;
    while (flag)
    {
        bool noStop = true;
        value = new Random().Next(10, 100);
        for (int x = 0; x < matrix.GetLength(0) && noStop; x++)
        {
            for (int y = 0; y < matrix.GetLength(1) && noStop; y++)
            {
                for (int z = 0; z < matrix.GetLength(2) && noStop; z++)
                {
                    if (matrix[x, y, z] == value) 
                        noStop = false; 
                    if (x == i && y == j && z == k) 
                        flag = false; 
                }
            }
        }
    }
    return value;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) 
                Console.Write($"{matrix[i, j, k], 1}({i},{j},{k}) \t");
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.WriteLine("Массив размером 2 x 2 x 2: ");
int[,,] matrix = new int[2, 2, 2];
InputMatrix(matrix);
PrintMatrix(matrix);