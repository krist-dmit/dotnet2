//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
Random rnd = new Random();
int[,] array (int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j]=rnd.Next(1,10);
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
    return array;
}
double[] arrayAVG (int[,] array)
{
    Console.WriteLine("Среднее значение по столбцам: ");
    double[] AvarageArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        AvarageArray[j] = sum / array.GetLength(0);
    }
    return AvarageArray;
}
Console.WriteLine(string.Join('\t', arrayAVG(array(2,3))));