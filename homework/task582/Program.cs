//: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
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
int Vvod(string text)
{
    Console.WriteLine(text);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
void Schet(int[,] array1, int[,] array2)
{
    if(array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Нет решения");
    }
    else
    {
        int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
        for(int k = 0; k < array1.GetLength(0); k++)
            {
                for(int i = 0; i < array2.GetLength(1); i++)
                {
                    int sum = 0;
                    for(int j = 0; j < array1.GetLength(1); j++)
                    {
                        sum =  sum + (array1[k,j]*array2[j,i]);
                    }
                    array3[k,i] = sum;
                    Console.Write($"{array3[k,i]} \t");
                }
                Console.WriteLine();
            }
    }
}

Schet(FillArray(
                Vvod("Введите количество строк 1й матрицы"),    
                Vvod("Введите количество столбцов 1й матрицы")),
        FillArray(
                Vvod("Введите количество строк 2й матрицы"),    
                Vvod("Введите количество столбцов 2й матрицы")));
