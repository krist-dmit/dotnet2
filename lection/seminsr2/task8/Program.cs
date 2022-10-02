void FindEven(int number)
{
    int index = 1;
    while (index < number)
    {
        if (index % 2 == 0)
        {
            Console.Write(index + " ");
        }
        index++;
    }
}

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt16(Console.ReadLine());
    return number;
}

int result = GetNumber();
FindEven(result);
