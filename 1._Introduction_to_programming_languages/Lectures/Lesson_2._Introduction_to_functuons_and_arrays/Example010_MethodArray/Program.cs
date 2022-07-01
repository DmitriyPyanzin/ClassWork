int[] array = {12, 91, 65, 52, 18, 59, 61, 18, 80};
int n = array.Length;
int find = 18;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}