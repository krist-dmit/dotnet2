// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Random rnd = new Random();
int [,] FillArray(int row, int column)
{
    int[,] array = new int[row,column];
    for(int i = 0; i < row; i++)
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

int Schet(int [,] array)
{
    int max  = 0;
    int answer = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if(sum > max)
        {
            max = sum;
            answer = i + 1;
        }
    }
    return answer;
}
Console.WriteLine(Schet(FillArray(3,3)));
