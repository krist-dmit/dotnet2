
Console.WriteLine("Введите число ");

int Number = Convert.ToInt16(Console.ReadLine());

if (Number mod 2 == 0)

{
    Console.WriteLine(Number + " - четное число");
}
else
{
    Console.WriteLine(Number + " - нечетное число");
}