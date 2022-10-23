// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Random rnd = new Random();
int[,] array (int row, int column)
{
    int[,] array =  new int[row,column];
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
    return array;
}
void method(int[,] array)
{
    Console.WriteLine("Введите строку");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(array[row-1,column-1]);
}

method(array(5,6));