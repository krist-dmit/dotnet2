int Vvod()
{
    Console.WriteLine("Введите пятизначное число");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
string Polindrom(int number)
{
    string answer = " ";
    int m = number % 10;
    int m1 = number / 10000;
    int l = number % 100 / 10;
    int l1 = number / 1000 % 10;
    if (m == m1 && l == l1) {
        answer = "Это число полиндром";
    }
    else {
        answer = "Это число не полиндром";
    }
    return answer;
}

Console.WriteLine(Polindrom(Vvod()));