//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

void FindMulti()
{
    Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    PrintMulti(array);
}

int[] FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] +", ");
    Console.WriteLine();
}

void PrintMulti(int[] array)
{
    Console.WriteLine();
    int revindex = array.Length - 1;
    int index = 0;
    while(index < array.Length / 2)
    {
        Console.Write(array[index] * array[revindex] + ", ");
        revindex--;
        index++;
    }
}

FindMulti();