// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
Random rnd = new Random();
int[] FillArray (int count)
{
   int[] array = new int[count];
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = rnd.Next(-10,10);
   }
   Console.WriteLine(String.Join(" ", array));
   return array;
}
int [] Change (int[] array)
{
    int [] brray = new int [array.Length];
    for(int i = 0; i < array.Length; i ++)
    { 
        brray[i] = array [i] * -1;
    }
    Console.WriteLine(String.Join(" ", brray));
    return (brray);
}
Change(FillArray(10));

