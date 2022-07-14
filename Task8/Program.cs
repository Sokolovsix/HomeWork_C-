Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

while(count <= N)
{
    if(count == N)
    {
      Console.WriteLine(count + " . ");
    }
    else
    {
        Console.WriteLine(count + " , ");
    }
    count = count + 2;
}
