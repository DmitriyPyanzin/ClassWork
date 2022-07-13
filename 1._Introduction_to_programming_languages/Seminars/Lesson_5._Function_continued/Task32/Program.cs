//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

void ReplNum()
{
    Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    ReplPrintArray(array);
}

int[] FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] +", ");
    Console.WriteLine();
}

void ReplPrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] * -1 +", ");
    Console.WriteLine();
}

ReplNum();