
// int Vvod()
// {
//     Console.WriteLine("Введите длину массива");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
int Vvod(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool NewMethod(int a, int b, int c)
{
    
    return !((a <= 0 || b <= 0 || c <= 0) || (a + b <= c || a + c <= b || b + c <= a));
    
}

//Console.WriteLine(NewMethod(3,4,5));
Console.WriteLine(
    NewMethod(
        Vvod("Первое число"),
        Vvod("Vtoroe"),
        Vvod("Tret")));
