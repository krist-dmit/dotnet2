//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random rnd = new Random();

int[] Array (int count)
{
    int[] massiv = new int[count];
    int i = 0;
    for (i=0; i < count; i++)
    {
        massiv[i] = rnd.Next(-1,3);
    }
    return massiv; 
}

int Schet (int[] massiv)
{
    int result = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if(i % 2 != 0) 
        {
            result = result + massiv[i];
        }
    }
    return result;
}
int[] massiv = Array(8);
Console.WriteLine(string.Join(' ' , massiv));  
Console.WriteLine(Schet(massiv));