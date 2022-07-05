
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
int size = Input("Введите количество элементов в массиве: ");
int [] array = new int [size];
int max = Input("Введите максимально возможное значение элемента: ");

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(max+1);
}

for (int i=0; i<array.Length; i++)
{
    Console.Write(array[i]);
    if(i+1<array.Length)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(". \n");
    }
}
