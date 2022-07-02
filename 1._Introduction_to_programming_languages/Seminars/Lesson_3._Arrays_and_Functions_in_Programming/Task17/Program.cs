Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
FindQuarter(num1, num2);

void FindQuarter(int x, int y)
{
    if(x > 0 && y > 0) Console.WriteLine("I-я четверть;");
    else if(x > 0 && y < 0) Console.WriteLine("IV-я четверть;");
    else if(x < 0 && y > 0) Console.WriteLine("II-я четверть;");
    else if(x < 0 && y < 0) Console.WriteLine("III-я четверть;");
    else Console.WriteLine("Точка находится на координатной прямой!");
}