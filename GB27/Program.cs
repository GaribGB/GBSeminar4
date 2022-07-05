Console.Clear();
int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}
int x = Input("Введите число");

int result = 0;
while (x>0)
{
    result = result + x%10;
    x = x/10;
}
Console.WriteLine(result);