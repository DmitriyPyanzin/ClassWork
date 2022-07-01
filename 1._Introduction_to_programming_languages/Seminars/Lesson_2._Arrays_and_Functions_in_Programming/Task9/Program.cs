//9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа.

Random rand = new Random();
int number = rand.Next(10, 100);
Zadacha9(number);

void Zadacha9(int currentNamber)
{
    Console.WriteLine(currentNamber);
    int digitFirst = currentNamber / 10,
        digitSecond = currentNamber % 10;

    if(digitFirst > digitSecond) 
       Console.WriteLine(digitFirst);
    else if (digitFirst < digitSecond) 
            Console.WriteLine(digitSecond);
    else 
        Console.WriteLine("Числа равны!");
}