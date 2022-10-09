//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int[] Vvod()
{
    int[] cord = new int[6];
    Console.WriteLine("Введите x1");
    cord[0] = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите y1");
    cord[1] = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите z1");
    cord[2] = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите x2");
    cord[3] = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите y2");
    cord[4] = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите z2");
    cord[5] = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine(string.Join(' ',cord));
    return cord;
}
double S(int[] cord)
{
    double result = Math.Sqrt(Math.Pow((cord[0]-cord[1]), 2) + Math.Pow((cord[2]-cord[3]), 2) + Math.Pow((cord[4]-cord[5]), 2));
    return result;
}
Console.WriteLine(S(Vvod()));
