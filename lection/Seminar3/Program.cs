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
Console.WriteLine("Введите количество посещений: ");
int count = Convert.ToInt32(Console.ReadLine());

string interval(string text, int count) 
{
    string interval = string.Empty;
    Console.WriteLine(text);
    int i = 0;
    while (i<=count-1)
    {
        interval = interval + " " + Console.ReadLine();
        i ++;
    }
    return interval;
}
string stringArray = interval("введите интервал", count); 
Console.WriteLine(stringArray.Length);
//Console.WriteLine(string.Join(' ',stringArray)); - Проверка
string remover = "-";
string chisla = stringArray.Replace(remover," ");
Console.WriteLine(chisla);
