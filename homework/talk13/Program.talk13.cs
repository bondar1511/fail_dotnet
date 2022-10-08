//Напишите метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 6, 78 -> третьей цифры нет, 32679 -> 6


internal class Program
{
    private static void Main(string[] args)
    {
        string str = 32679.ToString();
         Console.WriteLine(str[2]);
    }
}
    
