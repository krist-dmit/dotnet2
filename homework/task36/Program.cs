Random rnd = new Random();

int[] Array (int count)

{
    int[] result = new int[count];
    int i = 0;
    for (i=0; i < count; i++)
    {
        result[i] = rnd.Next(1,3);
    }
    return result;
}
int SumNechet (int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
    result += array[i];
    }
    return result;
}

int[] array = Array(6);

Console.WriteLine(string.Join(' ',array));
Console.WriteLine(SumNechet(array));