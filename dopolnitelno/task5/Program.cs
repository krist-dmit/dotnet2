// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
//и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Random rnd = new Random();
int[] FillArray (int count)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}
int [] Schet (int [] array)
{
    int count = 0;
    if(array.Length % 2 == 0)
    {
        count = array.Length/2;
    }
    else
    {
        count = array.Length/2 +1;
    }
    int [] brray = new int [count];
    for(int i = 0; i < brray.Length; i ++)
    {
        if(i == (array.Length-1)-i)
        {
            brray[i] = array[i];
        }
        else
        {
            brray[i] = array[i] * array[((array.Length-1)-i)];  
        }
    }
    Console.WriteLine(String.Join(" ", brray));
    return (brray);
}
Schet(FillArray(7));