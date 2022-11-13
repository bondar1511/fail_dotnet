// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.WriteLine("Введите значение M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            
                    
            while (M <= N)
            {
               sum = M + 1;
                sum += 1;
                return;                          
            }         
                Console.WriteLine($" Сумма натуральных чисел: {sum}");  
           }

        
                 
       
        }
    }
