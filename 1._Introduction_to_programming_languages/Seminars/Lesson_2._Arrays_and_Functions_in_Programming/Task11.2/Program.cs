Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
TripleNumber(number);

void TripleNumber(string number)
{
    Console.WriteLine(number);
    Console.Write(number[0]);
    Console.Write(number[2]);
    Console.WriteLine();
}