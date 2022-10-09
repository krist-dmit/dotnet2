
int Vvod()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int poisk(int chislo)
    {
        int result = 0;
        if (chislo < 100) 
        {
            Console.WriteLine("Третьего числа нет");
        }
        else {
            chislo = chislo / 100;
            result = chislo % 10;
        }
        return result;
    }

Console.WriteLine(poisk(Vvod()));
