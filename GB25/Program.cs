Console.Clear();
int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}
int a = Input("Введите a");
int b = Input("Введите b");



int result = 1;

for(int i=0; i<b; i++)
{
    result = result * a;
}

Console.WriteLine(result);