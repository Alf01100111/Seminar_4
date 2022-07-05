System.Console.WriteLine("Как вводим массив 1-руками, 2-случайный массив");
int choice = Convert.ToInt32(Console.ReadLine());
int[] RandomArr(int j)
{
    Random rnd = new Random();                  //как работает рандом? спросить на семинаре почему такая кривая конструкция
    int[] Arr8 = new int[j];
    for (int i = 0; i < Arr8.Length; i++)
    {
        Arr8[i] = rnd.Next(0, 100);              //как работает рандом? спросить на семинаре почему такая кривая конструкция
    }
    return Arr8;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]},");
    }
    System.Console.Write("\b\b");          // не работает!
}

int[] HandArr(int j)
{
    System.Console.WriteLine("Введите элементы в массив поочереди -");
    int[] Arr8 = new int[j];
    for (int i = 0; i < Arr8.Length; i++)
    {
        System.Console.Write($"{i} элемент= ");
        Arr8[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Arr8;
}
int[] result = new int[8];
if (choice == 1)
{
    result = HandArr(8);
    System.Console.WriteLine($"Ваш массив "); 
    PrintArr(result);
}
if (choice == 2)
{
    result = RandomArr(8);
    System.Console.WriteLine($"Ваш массив "); 
    PrintArr(result);
}
if (choice !=1 && choice !=2)
{
    System.Console.WriteLine("неверный ввод");
}
