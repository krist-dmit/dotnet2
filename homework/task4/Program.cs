
Console.WriteLine("Ввеите первое число: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ввеите второе число: ");
int b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ввеите третье число: ");
int c = Convert.ToInt16(Console.ReadLine());
int max = a;
if (max < b) {
    max = b;
           if (max < c) {
            max = c;
           }       
}
Console.WriteLine("Максимальное число - " + max);
