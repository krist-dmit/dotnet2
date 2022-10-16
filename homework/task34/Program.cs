// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Random rnd = new Random();

int[] Array (int count)

{
    int[] result = new int[count];
    int i = 0;
    for (i=0; i < count; i++)
    {
        result[i] = rnd.Next(100,999);
    }
    return result;
}

int Schet (int[] Array)
{
    int count = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}
Console.WriteLine(Schet(Array(10)));