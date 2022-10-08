
partial class Program
{
    static void Main(string[] args)
    {

        {
            Console.WriteLine("Введите число : ");
            int a = Convert.ToInt32(Console.Read());
            if (a % 2 == 0)
            {
                Console.WriteLine("да, четное ");
            }
            else
            {
                Console.WriteLine("нет, нечетное ");
            }

        }
    }
}