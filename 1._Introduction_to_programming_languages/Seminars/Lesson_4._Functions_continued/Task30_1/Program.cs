void Task30()
{
	//Задача 30: Напишите программу, которая выводит массив 
	//из 8 элементов, заполненный нулями и единицами в случайном порядке.
	int size = 8;
	int start = 1;
	int end = 2;
	int[] array = new int[size];
	FillArray(array, start, end);
	PrintArray(array);
}

int[] FillArray(int[] array, int start = 0, int end = 0)
{
	Random random = new Random(end);
	for(int i = 0; i < array.Length; i ++)
	{
        end++;
		array[i] = random.Next(start, end);
	}
	return array;
}

void PrintArray(int[] array)
{
	Console.WriteLine("Вывод массива");
	for(int i = 0; i < array.Length; i ++)
	{
		Console.Write(array[i] + " ");
	}
	Console.WriteLine();
}

Task30();