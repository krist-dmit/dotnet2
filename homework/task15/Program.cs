
int Vvod()
{
    Console.WriteLine("Введите число");
    int n = Convert.ToInt16(Console.ReadLine());
    return n;
}

string Schet(int n)
{
    string answer = " ";
    if (n < 8)

    {

        if (n == 6) 
            {
            answer = "Это суббота";
            }

        if (n == 7) {
            answer = "Это воскресенье";
            }

        if (n!=6 && n!=7) {
            answer = "Это будний день";
            }

    }
    else {
        answer = "Число не является днем недели";
    }
    return answer;
}

Console.WriteLine(Schet(Vvod()));