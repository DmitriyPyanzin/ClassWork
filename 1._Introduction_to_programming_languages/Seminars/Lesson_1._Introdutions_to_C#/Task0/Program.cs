//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
//цикл
//ветвление

//<тип_данных>  <имя_переменной>  =  <значения>;
//<тип_данных>  <имя_переменной>;
//int number = 5; //integer
Console.Write("Введите число, которое нужно возвести в квадрат ");
int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number * number);
//Console.WriteLine(Math.Pow(number, 2));
//Console.WriteLine("5 в квадрате равно " + Math.Pow(number, 2));
Console.WriteLine($"{number} в квадрате равно {number * number}");