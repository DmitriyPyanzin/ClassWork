﻿//Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

int a = 5, b = 4;

Recursion(a, b);

void Recursion(int a, int b, int result = 1)
{
    if (b == 0)
    {
        Console.WriteLine(result);
        return;
    }

    result *= a;
    b--;
    Recursion(a, b, result);
}