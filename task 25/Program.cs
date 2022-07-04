
System.Console.WriteLine("ВВедите число ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень ");
int pow = Convert.ToInt32(Console.ReadLine());

int Expon(int num, int power)
{
    int result = num;
    for (int i = 1; i < power; i++)
    {
        result *= num;
    }
    return result;
}

int final = Expon(number,pow);
System.Console.Write($"{number} в степени {pow} = {final}");
