//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void FindNum()
{
    Console.WriteLine("Введите длину массива: ");
    int size = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите искомое число: ");
    int num = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    NumInArray(array, num);
}

int[] FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 5);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] +", ");
    Console.WriteLine();
}

void NumInArray(int[] array, int num)
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        {
            flag = !flag;
            break;
        }
    }
    if(flag == true) Console.WriteLine($"Число {num} есть в массиве!");
    else Console.WriteLine($"Числа {num} нет в массиве!");
}

FindNum();