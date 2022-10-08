// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

void Zadacha67()
{
    int num = int.Parse(Console.ReadLine());
    int sum = Recursion(num);
    Console.WriteLine(sum);
}

int Recursion(int num)
{
    if (num / 10 > 0) return Recursion(num / 10) + num % 10;
    return num;
}

Zadacha67();