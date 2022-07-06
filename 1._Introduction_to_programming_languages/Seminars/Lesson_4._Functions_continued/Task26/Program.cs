void Task26()
{
    //Задача 26: Напишите программу, которая принимает на вход число 
    //и выдаёт количество цифр в числе.
	
	Console.Clear();
	Console.Write("Введите число: ");
	int number = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine($"Веденоое число {number} состоит из {NumbersofDigits(number)} цифр");
}

int NumbersofDigits(int number)
{
	int i;
	for(i = 0; number > 0; i++)
	{
		number /= 10;
	}
	return i;
}

Task26();