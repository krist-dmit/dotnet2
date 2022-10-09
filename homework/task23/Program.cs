// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Vvod()
{
    Console.WriteLine("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

int Pow(int N)
{
    int result = 0;
    for (int index = 1; index <= N; index++)
    {
        result = Convert.ToInt32(Math.Pow(index, 3));
        Console.WriteLine(index + "^3 = " + result);
    }
    return result;
}
Pow(Vvod());
