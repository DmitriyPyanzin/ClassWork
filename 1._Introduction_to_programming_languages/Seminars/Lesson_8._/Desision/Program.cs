//Задача 53: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.
/*
void Zadacha53()
{
    Random rand = new Random();
    int rows = rand.Next(2, 6);
    int columns = rand.Next(2, 6);

    int[,] array = new int[rows, columns];  
    
    FillMatrix(array, rows, columns);
    PrintMatrix(array, rows, columns);
    Console.WriteLine();
    CastlingMatrix(array, rows, columns);
    PrintMatrix(array, rows, columns);

}

void FillMatrix(int[,] array, int rows, int columns)
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

void PrintMatrix(int[,] array, int rows, int columns)
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

int[,] CastlingMatrix(int[,] array, int rows, int columns)
{
    int castling;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == 0)
            {
                castling = array[rows - 1, j];
                array[rows - 1, j] = array[i, j];
                array[i, j] = castling;
            }
        }
    }
    return array;
}

Zadacha53();*/

//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для пользователя.
/*
void Zadacha55()
{
    Random rand = new Random();
    int rows = 3;  //rand.Next(2, 6);
    int columns = 3;  //rand.Next(2, 6);

    int[,] array = new int[rows, columns];  
    
    FillMatrix(array, rows, columns);
    PrintMatrix(array, rows, columns);
    Console.WriteLine();
    if(rows == columns)
    {
        MatrixReplacement(array, rows, columns);
        PrintMatrix(array, rows, columns);
    }

    else Console.WriteLine("Inposible");

}

void FillMatrix(int[,] array, int rows, int columns)
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

void PrintMatrix(int[,] array, int rows, int columns)
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


int[,] MatrixReplacement(int[,] array, int rows, int columns)
{
    int temp;
    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}

Zadacha55();
*/
//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент входных данных.
/*
void Zadacha57()
{
    Random rand = new Random();
    int rows = rand.Next(2, 5);
    int columns = rand.Next(3, 5);

    int[,] array = new int[rows, columns];  
    int[] dictionary = new int[10];
    
    FillMatrix(array, rows, columns);
    PrintMatrix(array, rows, columns);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dictionary[array[i, j]]++;
        }
    }
    Console.WriteLine();
    for (int i = 0; i < dictionary.Length; i++)
    {
        if (dictionary[i] != 0) Console.WriteLine($"Элемент {i} встречается {dictionary[i]} раз");    
    }
}

void FillMatrix(int[,] array, int rows, int columns)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] array, int rows, int columns)
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


Zadacha57();
*/
//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
//строку и столбец, на пересечении которых расположен наименьший элемент массива.

void Zadacha59()
{
    Random rand = new Random();
    int rows = rand.Next(2, 5);
    int columns = rand.Next(3, 5);

    int[,] array = new int[rows, columns];  
    
    FillMatrix(array, rows, columns);
    PrintMatrix(array, rows, columns);
}

void FillMatrix(int[,] array, int rows, int columns)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(-10, 11);
        }
    }
}

void PrintMatrix(int[,] array, int rows, int columns)
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


Zadacha59();