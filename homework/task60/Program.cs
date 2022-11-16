//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
Random rnd = new Random();

int[] Check(int c)
{
    int[] array2 = new int[c];
    int t = rnd.Next(1,10);
    for (int l = 0; l < array2.Length; l++)
    {
        if (t != array2[l])
        {
            if (array2[l] == 0)
            {
                array2[l] = t;
                t = rnd.Next(1, 10);
                // Console.Write($"{array2[l]}  ");
                l = -1;
            }
        }
        else
        {
            t = rnd.Next(1, 10);
            l = -1;
        }
    }
    return array2;
}

int[,,] Method()
{
    int[,,] array = new int[2,2,2];
    int c = array.GetLength(0)*array.GetLength(1)*array.GetLength(2);
    int [] array2 = Check(c);
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            for(int k =0; k<array.GetLength(2); k++)
            {
                array[i,j,k]=array2[c-1];
                c = c - 1;
                Console.WriteLine($"{array[i,j,k]} ({i}, {j}, {k})");
            }
        }
    }
    return array;
}
Method();