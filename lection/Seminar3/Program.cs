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
string interval() 
{
    string[] interval = new string[9];
    Console.WriteLine("Введите интервал");
    int i = 0;
    while (i<=9)
    {
        string interval[i] = Console.ReadLine();
        i ++;
    }
    return interval;
}
string[] stringArray = interval;
Console.Write(interval);