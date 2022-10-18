// Есть магазин "Ромашка"
// Охранник ведёт журнал посещения
// 11-13
// 10-14
// 9-10
// 11-22
// 18-18
// 0-23
// 4-5
// 4-5
// 4-5

// Суть: показать интервалы, когда было больше всего 
// людей в магазине

// Ответ: 4-5, 11-13

Random rnd = new Random();
string[] vremya()
{
    string[] zhurnal = new string[5];
    int a = 0;
    int b = 0;
    int i = 0;
    for (i = 0; i < zhurnal.Length; i++)
    {
        a = rnd.Next(0, 23);
        b = rnd.Next(0, 23);
        if (a > b)
        {
            zhurnal[i] = Convert.ToString(b) + "-" + Convert.ToString(a);
        }
        if (a < b)
        {
            zhurnal[i] = Convert.ToString(a) + "-" + Convert.ToString(b);
        }
        if (a == b)
        {
            zhurnal[i] = Convert.ToString(a) + "-" + Convert.ToString(b);
        }
    }
    return zhurnal;
}
//Console.WriteLine(string.Join(' ', vremya()));
int[] Interval(string[] c)
{
    int[] ludi = new int[24];
    string y = string.Empty;
    string y1 = string.Empty;
    int j = 0;
    for (j = 0; j < c.Length; j++)
    {
        string t = c[j];
        if (t.Length == 5)
        {
            y = Convert.ToString(t[0]) + Convert.ToString(t[1]);
            y1 = Convert.ToString(t[3]) + Convert.ToString(t[4]);
        }
        if (t.Length == 4)
        {
            if (Convert.ToString(t[1]).Equals("-"))
            {
                y = Convert.ToString(t[0]);
                y1 = Convert.ToString(t[2]) + Convert.ToString(t[3]);
            }
            else
            {
                y = Convert.ToString(t[0]) + Convert.ToString(t[1]);
                y1 = Convert.ToString(t[3]);
            }
        }
        if (t.Length == 3)
        {
            y = Convert.ToString(t[0]);
            y1 = Convert.ToString(t[2]);
        }

        int u = Convert.ToInt32(y);
        int u1 = Convert.ToInt32(y1);

        for (int i = u; i < u1; i++)
        {
            ludi[i] = ludi[i] + 1;
        }
    }

    return ludi;
}
int[] ludi = Interval(vremya());
Console.WriteLine(string.Join(' ', ludi));
string MaxFind(int[] ludi)
{
    int i = 0;
    int max = ludi[0];
    int maxStartIndex = 0;
    int maxStopIndex = 0;
    for (i = 1; i < ludi.Length; i++)
    {
        
        if (ludi[i] > max)
        {
            max = ludi[i];
            maxStartIndex = i;
        }
    }
    for (i = maxStartIndex; i < ludi.Length-1; i++ )
    {
        if (ludi[i]== max)
        {
            maxStopIndex = i;
        }
        else 
        {
            break;
        }
    }
    string answer = ("Больше всего посетителей в количестве: " + max + 
     " было в интервал с " + maxStartIndex + " по " + maxStopIndex);

    return answer;
}
Console.WriteLine(MaxFind(ludi));

