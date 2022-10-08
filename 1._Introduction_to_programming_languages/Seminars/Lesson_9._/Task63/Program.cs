//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от 1 до N.

void Zadacha63()
{
    int number = 15;
    int count = 1;
    Recursion(count, number);
    Console.WriteLine();

    void Recursion(int count, int number)
    {
        if (count > number) return;
        Console.Write(count + " ");
        count++;
        Recursion(count, number);
    }
}

Zadacha63();