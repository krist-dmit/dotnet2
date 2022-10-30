// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Random rnd = new Random();
int[] Vvod(int count)
{
   int[] array = new int[count];
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = rnd.Next(-9,9);
   }
   Console.WriteLine(String.Join(" ", array));
   return array;
}
void Schet(int [] array)
{
    int negativ = 0;
    int pozitiv = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            negativ = negativ + array[i];
        }
        else
        {
            pozitiv = pozitiv + array[i];
        }
    }
    Console.WriteLine("Сумма положительных элементов: " + pozitiv);
    Console.WriteLine("Сумма отрицательных элементов: " + negativ);
}
Schet(Vvod(12));






// void Schet(int[] array)
// {
//     int countPositive = 0;
//     int countNegative = 0;
//     for(int i = 0; i<array.Length; i ++)
//     {
//         if(array[i]>0)
//         {
//             countPositive += array[i];
//         }
//         if(array[i]<0)
//         {
//             countNegative += array[i];
//         }
//     }
//     Console.WriteLine("Сумма положительных элементов: " + countPositive);
//     Console.WriteLine("Сумма отрицательных элементов: " + countNegative);
// }
// Schet(Vvod(12));


