Console.Write("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());
SquaresNambers(count);

void SquaresNambers(int num)
{
    for(int i = 1; i <= num; i++)
    {
        Console.Write(i * i + " ");
    }
    
}