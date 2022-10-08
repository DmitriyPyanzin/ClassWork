//Вид1 - метод не принимает агументов и не возвращает значений
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

//Вид2 - метод принимает аргументы, но не возвращает значения
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");        // msg: это обращение к конкретному аргументу

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(count: 3, msg: "Текст");           //Благодаря такому методу не обязательно вписывать аргументы по порядку

//Вид3 - метод не принимает аргументы, но возвращает значение
string Method3()
{
    int day = DateTime.Now.Day;
    int month = DateTime.Now.Month;
    int year = DateTime.Now.Year;
    string text = day + ":" + month + ":" + year;
    return text;
}

string date = Method3();
Console.WriteLine(date);

//Вид4 - метод принимает аргументы и возвращает значение
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;   //Означает пустую строку, это общепринятое написание, но можно и ""
    
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
} 
string res = Method4(10, "asdf");
Console.WriteLine(res);

string Method41(int count, string text) // Работа цикла for
{
    string result = "";   

    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
} 
string res1 = Method41(10, "z");
Console.WriteLine(res1);

//Цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}