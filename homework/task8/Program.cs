Console.WriteLine("Введите число: ");
int number = Convert.ToInt16(Console.ReadLine());
int index = 1;
while (index < number) 
{
    if (index % 2 == 0){
        Console.Write(index + " ");
    }
    index ++;
}
