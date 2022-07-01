Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 != 0)
{
    int div = num2 % num1; 
    Zadacha12(div);
}
else Console.WriteLine("Ну и что же ты ввел?");

void Zadacha12(int currentNumber)
{
    if(currentNumber == 0) Console.WriteLine("Yes");
    else if(num1 == 0) Console.WriteLine("Ну только не 0");
    else Console.WriteLine(currentNumber);
}