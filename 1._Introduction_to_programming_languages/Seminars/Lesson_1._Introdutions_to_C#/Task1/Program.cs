Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberB == numberA * numberA)
{
    Console.WriteLine($"Второе число {numberB} является квадратом первого числа {numberA}");
}
else
{
    Console.WriteLine($"Второе число {numberB} не является квадратом первого числа {numberA}");
}