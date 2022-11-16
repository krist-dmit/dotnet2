//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int Method (int M, int N)
{
    if (M==N)
    {
        return N;
    }
    else
    {
        return Method(M+1,N)+M;
    }
}
Console.WriteLine(Method(1,5));