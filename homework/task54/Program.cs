// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
    Console.WriteLine();
   return array;
}
int Vvod(string text)
{
    Console.WriteLine(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int [,] Poryadok(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            if(array[i,j] < array[i,j+1])
            {
                int k = array[i,j];
                array[i,j] = array[i,j+1];
                array[i,j+1] = k;
                j = -1;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");           
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    
    return array;
}
Poryadok(FillArray(Vvod("Ведите количество строк:"), Vvod("Ведите количество столбцов:")));
