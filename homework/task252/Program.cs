// : опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 без math.pow

int Vvod (string text)
{
    Console.WriteLine(text);
    int N = Convert.ToInt16(Console.ReadLine());
    return N;
}

int Schet (int A, int B)
{
    int result = 1;
    for(int i = 0; i < B; i++)
    {
        result = result * A;
    } 
    return result;
}

string text = "Введите число A";
int A = Vvod (text);
string text2 = "Введите число B";
int B = Vvod(text2);
Console.WriteLine(Schet(A, B));
