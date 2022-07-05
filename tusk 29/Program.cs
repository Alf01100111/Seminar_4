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
        System.Console.Write(" ", arr[i]);
    }
    System.Console.Write("\b\b");           //почему не работает затирание последнего символа?
}


int[] HandArr(int j)
{
    System.Console.WriteLine("Введите элементы в массив поочереди -");
    int[] Arr8 = new int[j];
    for (int i = 0; i < Arr8.Length; i++)
    {
        System.Console.Write($"{i + 1} элемент=");
        Arr8[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Arr8;
}

int[] finall = HandArr(8);
PrintArr(finall);
