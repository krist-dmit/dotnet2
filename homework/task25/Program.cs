// опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Vvod (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int vozvedenie (int osnovanie, int stepen)
{
    int result = 1;
    int i = 0;
    for (i = 0; i < stepen; i++)
    {
        result = result * osnovanie;
    }
    return result;
}

Console.WriteLine(vozvedenie(
    Vvod("Введите основание: "),
    Vvod("Введите степень: ")
));