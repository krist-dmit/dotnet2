int[] Array (int count, string text)
{
    int[] result = new int[count];
    int i = 0;
    for (i=0; i < count; i++)
    {
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}
int Schet (int[] array)
{
    int count = 0; 
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            count += 1;
        }
    }
    return count;
}
int[] massiv = Array(4, "Введите числа");
Console.WriteLine(string.Join(' ',massiv));
Console.WriteLine(Schet(massiv));
