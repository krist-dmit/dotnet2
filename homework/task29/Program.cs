// Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random rnd = new Random();

int[] Array (int count)

{
    int[] result = new int[count];
    int i = 0;
    for (i=0; i < count-1; i++)
    {
        result[i] = rnd.Next(0,10);
    }
    return result;
}

Console.WriteLine(string.Join(' ', Array(8)));
