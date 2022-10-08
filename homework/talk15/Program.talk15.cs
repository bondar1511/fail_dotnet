        //Напишите метод, который принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
        //6 -> да,7 -> да, 1 -> нет



internal partial class Program
{
    private static void Main(string[] args)
    {

        Concole.WriteLine("ВВедите день недели от 1 до 7");
        {
            DateTime date = DateTime.Now;
            dateToday.Text = " " + date.ToString("d");
            DayOfWeek day = DateTime.Now.DayOfWeek;
            dayToday.Text = " " + day.ToString();

            if (dayToday == DayOfWeek.Saturday && dayToday == DayOfWeek.Sunday)
            {
                Console.WriteLine("выходнонй день");
            }

        }
    }
}