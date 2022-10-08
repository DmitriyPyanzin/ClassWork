//Задача 61: Задайте две матрицы. Напишите
//программу, которая будет находить произведение двух матриц.

Random rand = new Random();
int rowsFirst = rand.Next(3, 6);
int columnsFirst = rand.Next(3, 7);

int rowsSecond = columnsFirst;
int columnsSecond = rand.Next(3, 7);

int[,] arrayFirst = new int[rowsFirst, columnsFirst];
int[,] arraySecond = new int[rowsSecond, columnsSecond];
int[,] result = new int[rowsFirst, columnsSecond];

FillArray(arrayFirst);
FillArray(arraySecond);
PrintArray(arrayFirst);
PrintArray(arraySecond);

for (int i = 0; i < rowsFirst; i++)
{
    for (int j = 0; j < columnsSecond; j++)
    {
        for (int k = 0; k < rowsSecond; k++)
        {
            result[i, j] += arrayFirst[i, k] * arraySecond[k, j];
        }
    }
}

PrintArray(result);

int[,] FillArray(int[,] array)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}