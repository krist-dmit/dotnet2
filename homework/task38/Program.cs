//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Random rnd = new Random();
double[] Array(int count)
{
    double[] massiv = new double[count];
    int i = 0; 
    for(i = 0; i<count; i++)
    {
        massiv[i] = rnd.NextDouble()*100;
    }
    return massiv;
 }

 double Schet(double [] massiv)
 {
    double max = massiv[0];
    double min = massiv[0];
    double result = 0;
    int count = massiv.Length;
    for (int i = 1; i < count; i++)
    {
        if(max<massiv[i])
        {
        max = massiv[i];
        }
        if(min>massiv[i])
        {
        min = massiv[i];
        }
    }
    result = max - min;
    return result;
 }
 Console.WriteLine(Schet(Array(4)));