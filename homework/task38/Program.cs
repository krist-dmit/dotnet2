Random rnd = new Random();

int[] Array (int count)

{
    int[] result = new int[count];
    int i = 0;
    for (i=0; i < count; i++)
    {
        result[i] = rnd.Next(1,8);
    }
    return result;
}

int Max (int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++ )
    {
        if (array[i]>max) 
        {
            max = array[i];
        }
    }
    return max;
}

int Min (int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++ )
    {
        if (array[i]< min)
        {
            min = array[i];
        }
    }
    return min;
}
int[] array = Array(8);
Console.WriteLine(string.Join(' ',array));
Console.WriteLine(Max(array)-Min(array));
