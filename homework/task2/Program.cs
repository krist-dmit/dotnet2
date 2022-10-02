
Console.WriteLine("Введите первое число");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt16(Console.ReadLine());
int max = a;
int min = b;
if (a < b) 
{
    max = b;
    min = a;
}

Console.WriteLine ("Число " + max + " больше, чем " + min);
