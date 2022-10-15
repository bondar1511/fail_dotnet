// Задача 25: опишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// без math.pow


internal class Program
{
    private static void Main(string[] args)
    {
       Console.Write("Введите число A: ");
        int A = Convert.ToInt32(Console.Read());
        Console.Write("Введите число B: ");
        int B = Convert.ToInt32(Console.Read());
        int result = 0;
       
       for(A =1; A <= B; A++)
{

    result = result*A;

}
        
     Console.Write(result); 
        }
   
    }
