//Задача 46: Задайте двумерный массив размером m (строка)× n(столбец), заполненный случайными целыми числами.
/*
//void Zadacha46()
{
    int rows = 4;
    int columns = 5;

    int[,] array = new int[rows, columns];  // массив 4х5
    // "\t" - перевод на другую строку
    //array.GetLength(0) - столбцы
    //array.GetLength(1) - строки
    //FillArray(array, rows, columns);
    //PrintArray(array, rows, columns);
}

//void FillArray(int[,] array, int rows, int columns)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 11);
        }
    }
}

//void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

//Zadacha46();
*/
//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n. Выведите полученный массив на экран.
/*
void Zadacha48()
{
    int rows = 3;
    int columns = 4;

    int[,] array = new int[rows, columns];
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
}

void FillArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

Zadacha48(); */

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
/*
void Zadacha49()
{
    int rows = 4;
    int columns = 5;

    int[,] array = new int[rows, columns];  
    
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
    Console.WriteLine();
    PowerArray(array, rows, columns);
}

void FillArray(int[,] array, int rows, int columns)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

void PowerArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadacha49(); */

//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void Zadacha51()
{
    int rows = 4;
    int columns = 5;

    int[,] array = new int[rows, columns];  
    
    FillArray(array, rows, columns);
    PrintArray(array, rows, columns);
    Console.WriteLine();
    SumArray(array, rows, columns);
}

void FillArray(int[,] array, int rows, int columns)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

void SumArray(int[,] array, int rows, int columns)
{
    int sum = 0;
    int i = 0;
    while(i < rows && i < columns)
    {
        sum += array[i, i];
        Console.Write(array[i, i] + "+");
        i++;
    }

    Console.Write("\b");
    Console.WriteLine($"=" + sum);
}

Zadacha51();