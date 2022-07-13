//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

void FindNum()
{
    Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine($"В массиве {NumInArray(array)} чисел(-о, -а) из диапозона от 10 до 99!");
}

int[] FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 1001);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] +", ");
    Console.WriteLine();
}

int NumInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

FindNum();