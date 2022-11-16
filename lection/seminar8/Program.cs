Random rnd = new Random();
int n = 4;
int[] array = new int[n];
int[] FillArray (int i)
{
    array[i] = rnd.Next(0,10);
    if (i < n) FillArray(i+1);
    return array;
}

void Vyvod (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(string.Join(' ' , array));  
    }
}
Vyvod(FillArray(0));
