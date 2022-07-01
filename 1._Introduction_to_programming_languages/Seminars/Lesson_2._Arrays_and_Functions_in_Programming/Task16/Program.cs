void FindNumber(int number, int currentNumber)
{
    if(number * number == currentNumber) Console.WriteLine("Yes");
    else Console.WriteLine("NO");
}

Console.Write("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
FindNumber(num1, num2);