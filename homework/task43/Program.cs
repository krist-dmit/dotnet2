// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Vvod(string text)
{
    Console.WriteLine(text);
    double count = Convert.ToDouble(Console.ReadLine());
    return count;
}
void Schet(double k1, double b1,double k2, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k2 * x + b2;
    Console.WriteLine(x + ";" + y);
}
Schet(Vvod("Введите k1"),
      Vvod("Введите b1"),
      Vvod("Введите k2"),
      Vvod("Введите b2"));
