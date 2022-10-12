// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Vvod (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int schet (int number)
{
    int result = 0;
    while (number / 10 > 0)
    {
       result = result + (number % 10);
       number = number / 10;
    }
    result = result + number;
    return result;
}
Console.WriteLine(schet(Vvod("Введите ваше число: ")));