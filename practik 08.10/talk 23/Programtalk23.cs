//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27;5 -> 1, 8, 27, 64, 125


internal class Program
{
    private const int V = 100;

    private static void Main(string[] args)
    {
        int i = 0;
        int result = 0;

        for (i = 1; i < V; i++)
        {
            result = i * i * i;
            Console.Write(result);
       
        }

    }
}
