// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Random rnd = new Random();
// int[] FillArray (int count)
// {
//     int[] array = new int[count];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(1,123);
//     }
//     Console.WriteLine(String.Join(" ", array));
//     Console.WriteLine();
//     return array;
// }
// int Find (int [] array)
// {
//     int count =0;
//     for(int i = 0; i < array.Length; i ++)
//     {
//         if( array[i] > 10 & array[i] < 99)
//         {
//             count = count +1;
//         }
//     } 
//     return count;
// }

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{   Console.WriteLine($"{with}, {on},{some},{count}");
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with}>>{on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
