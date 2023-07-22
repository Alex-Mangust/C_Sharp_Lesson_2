int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};
int n = array.Length;
int find = 1;
int index = 0;
int count = 0;
while(index < n)
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    count++;
    }
    index++;
}
if(count > 1)
{
    Console.WriteLine("В массиве " + count + " одинаковых элементов.");
}