Random rand = new Random();
int number = rand.Next(100, 1000);
FindNumber(number);

void FindNumber(int currentNumber)
{
    Console.WriteLine($"Случайное число равно {currentNumber}");
    Console.Write($"Новое число {currentNumber / 100 * 10 + currentNumber % 10}");    
}