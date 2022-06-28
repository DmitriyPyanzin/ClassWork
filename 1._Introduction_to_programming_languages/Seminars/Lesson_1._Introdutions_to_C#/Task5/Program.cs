int number = 6;
//Console.WriteLine(number * number);
//Console.WriteLine(Math.Pow(number, 2));
number = 2;
OurPower(number); // Вызов функции
OurPower(7); // Вызов функции
OurPower(number + number); // Вызов функции
//OurPower(1.5); // Вызов функции

void OurPower(int currentNumber)
{
    Console.WriteLine(currentNumber * currentNumber);
}