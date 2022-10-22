//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Vvod()
{
    Console.WriteLine("Введите количсетво чисел:");
    int Number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[Number];
    for(int i = 0; i<Number; i++)
    {
        Console.WriteLine("Введите число:");
        array[i]= Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}
int Schet (int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]>0)
        {
            count = count +1;
        }
    }
    return count;
}
Console.WriteLine(Schet(Vvod()));
