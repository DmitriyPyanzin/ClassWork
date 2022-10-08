//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void Zadacha65()
{
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());

    Recursion(m, n);
}

void Recursion(int num1, int num2)
{
    if (num1 == num2) return;
    Console.Write(num1 + " ");
    num1++;
    Recursion(num1, num2);
}

Zadacha65();