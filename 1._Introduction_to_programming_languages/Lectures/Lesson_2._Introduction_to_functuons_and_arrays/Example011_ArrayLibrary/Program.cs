void FillArray(int[] collection)      // метод добавляет в массив рандомные элементы
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)            // метод печатающий элементы
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}

int IndexOf(int[] collection, int find)    // метод позволяющий найти нужный элемент
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];              // Создание массива с десятью элементами, по умолчанию все они равны 0

FillArray(array);
array[4] = 4;  //Принудительно создали в элементе 4 значение 4
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 40);
Console.WriteLine(pos);