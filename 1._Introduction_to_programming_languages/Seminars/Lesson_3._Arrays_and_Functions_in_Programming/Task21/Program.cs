Console.WriteLine("Введите координаты первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
FindLen(x1, y1, x2, y2);

void FindLen(int xa, int ya, int xb, int yb)
{
    double A = Math.Pow(xa - xb, 2);
    double B = Math.Pow(ya - yb, 2);
    Console.WriteLine($"Длинна отрезка равна {Math.Sqrt(A + B)}");
}