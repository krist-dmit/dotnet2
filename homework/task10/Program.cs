
int Vvod()
{
    Console.WriteLine("Введите трехзначное число");
    int number = Convert.ToInt16(Console.ReadLine());
    return number;
}

int Find(int N)
    {
     int result = N / 10;
     int answer = result % 10;
     return answer;
    }

Console.WriteLine(Find(Vvod()));