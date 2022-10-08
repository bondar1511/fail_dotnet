//Задача 10: Напишите метод, который принимает на вход трёхзначное число 
// на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

internal class Program
{
    private static void Main(string[] args)
    {
        string str = 456.ToString();
        Console.WriteLine(str[1]);
    }
}