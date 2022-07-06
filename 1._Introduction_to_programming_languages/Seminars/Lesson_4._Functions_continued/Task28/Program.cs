void Task28()
{
	//Задача 28: Напишите программу, которая принимает на вход число N 
	//и выдаёт произведение чисел от 1 до N.
	
	Console.Write("Введите число: ");
	int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Факториал числа {num} равен {FindFact(num)}");	
}

int FindFact(int number)
{
	int fact = 1;
	for(int i = 1; i <= number; i++)
	{
		fact *= i;
	}
	return fact;
}

Task28();