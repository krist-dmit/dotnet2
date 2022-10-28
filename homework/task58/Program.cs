Random rnd = new Random();
int[,] Array1 (int row, int column)
{
    int[,] first = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            first[i,j] =  rnd.Next(0,9);
            Console.Write($"{first[i,j]} \t");           
        }
        Console.WriteLine();
    }
    return first;
}

Console.WriteLine("Первая матрица: ");
int[,] array1 = Array1(2,3);

Console.WriteLine("Вторая матрица: ");
int[,] array2 = Array1(4,3);

int[,] Schet(int [,] array1, int [,] array2)
{
    if (array1.GetLength(1)!=array2.GetLength(0))
    {
        Console.WriteLine("Ответа нет" );
        return new int[1,1];
    }
    int[,] array3 = new int[2,3];
    for(int k = 0; k < array1.GetLength(0); k++)
    {
        for(int i = 0; i < array2.GetLength(1); i++)
        {
            int result = 0;
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                result = result + array1[k,j]*array2[j,i];
                array3[k,i]=result;
            }
        }
             
    }
    return array3;
}

int[,] array3 = Schet(array1, array2);
Console.WriteLine("Answer: ");
for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++){
        Console.Write($"{array3[i,j]} \t");
    }
    Console.WriteLine();
}
