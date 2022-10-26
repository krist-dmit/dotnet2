//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Random rnd = new Random();
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            array[i,j] = rnd.Next(1,10);
            Console.Write($"{array[i,j]} \t");           
        }
        Console.WriteLine();
    }
   return array;
}
int Vvod(string text)
{
    Console.WriteLine(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
void Find ( int[,]array, int row, int column)
{
    if(row >= array.GetLength(0) || column >= array.GetLength(1))
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        Console.WriteLine(array[row,column]);
    }
}
Find(FillArray(5,2),
    Vvod("Введите строку: "),
    Vvod("Введите столбец: "));