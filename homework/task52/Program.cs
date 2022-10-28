//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double Average (int [,] array)
{        
    double result = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        result = 0;
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum = (sum + array[j,i]);
        }
        result = sum/array.GetLength(0);
        Console.Write($"{result} \t");
    }
    return result;
}
Average(FillArray(
        Vvod("Введите количество строк: "), 
        Vvod("Введите количество стобцов:")));