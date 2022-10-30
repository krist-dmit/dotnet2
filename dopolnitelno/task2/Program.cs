// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Random rnd = new Random();
int[] FillArray (int count)
{
   int[] array = new int[count];
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = rnd.Next(-100,100);
   }
   Console.WriteLine(String.Join(" ", array));
   return array;
}
int Vvod(string text)
{
    Console.WriteLine(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
string Find (int[] array, int count)
{
    string answer = string.Empty;
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i] == count)
        {
            answer = "в массиве есть число: " + Convert.ToString(count);
            //Console.WriteLine("Число " + count + " в массиве есть");
            break;
        }
        if(array[i] != count )
        {
            answer = "в массиве нет числа: " + Convert.ToString(count);
            //Console.WriteLine("Число " + count + " в массиве нет");
        }
    }
    return answer;
}
Console.WriteLine(Find(FillArray(10),Vvod("Введите число")));