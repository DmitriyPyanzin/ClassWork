Console.Write("Введите число от 1 до 4: ");
int number = Convert.ToInt32(Console.ReadLine());
FindCoord(number);

void FindCoord(int num)
{
    if(num == 1) Console.WriteLine("X > 0 and Y > 0");
    else if(num == 2) Console.WriteLine("X < 0 and Y > 0");
    else if(num == 3) Console.WriteLine("X < 0 and Y < 0");
    else if(num == 4) Console.WriteLine("X > 0 and Y < 0");
    else Console.WriteLine("Ты что-то не то ввел (-а)!");
}