//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
Random rnd = new Random();
int[,,] Method()
{
    int[,,] array = new int[2,2,2];
    int [] array2 = new int[8];
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(int j =0; j<array.GetLength(1); j++)
        {
            for(int k =0; k<array.GetLength(2); k++)
            {
                int t = rnd.Next(1,9);
                for (int l = 0; l < array2.Length; l++)
                {
                    if(t != array2[l])
                    {
                        if(array2[l] == 0)
                        {
                            array2[l] = t;
                            break;
                        }
                    }
                    else
                    {    
                        t = rnd.Next(1,9);
                        l = -1;
                    }
                }
                array[i,j,k]=t;
                Console.WriteLine($"{array[i,j,k]} ({i}, {j}, {k})");
            }
        }
    }
    return array;
}
Method();
