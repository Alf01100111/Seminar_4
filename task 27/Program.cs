
int sumInNum(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += (num%10);
        num /= 10;
    }
    return result;
}
System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе {sumInNum(number)}");