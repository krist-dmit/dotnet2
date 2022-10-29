// Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы,
// так чтобы в одной группе все числа были взаимно просты.

int count = 50;
int [,] array = new int [count, count];
int k = 1;
int i = 0; 
int j = 0;
while(k <= count)
    {
        i = 0;
        while(i<count)
        {
            j = 0;
            while(j<count)
            {
                if(array[i,j]==0)
                {
                    array[i,j] = k;
                    k = k+1;
                    i = count;
                    j = count;
                }
                else
                {
                    if(k % array[i,j] == 0)
                    {
                        i = i+1;
                        j = 0;
                    }
                    else
                    {
                        j = j+1;
                    }
                }
            }
        }
    }

int result = 0;
j = 0;
for ( i = 0; i < array.GetLength(0); i++)
    {
        if( array [i,j] != 0)
        {
            result = result + 1;
        }
    }
Console.WriteLine(result);
        
