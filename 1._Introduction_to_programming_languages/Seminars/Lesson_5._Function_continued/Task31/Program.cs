//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

void Zadacha31()
{
    int size = 6;
    int[] array = new int[size];
    FillArray(array, -5, 5);
    PrintArray(array);
        
    Console.WriteLine("Сумма положительных элементов массива равна " + SumPositive(array));
    Console.WriteLine("Сумма отрицательных элементов массива равна " + SumNegative(array));
}

int SumNegative(int[] array)
{
    int sumNegative = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumNegative += array[i];
    }
    return sumNegative;
}

int SumPositive(int[] array)
{
    int sumPositive = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i];
    }
    return sumPositive;
}

int[] FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random(0);

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

Zadacha31();