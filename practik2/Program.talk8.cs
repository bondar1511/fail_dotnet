internal partial class Program
{
 
    private static void Main(string[] args)
    {   Console.Write("Введите первое число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число");
        int n = Convert.ToInt32(Console.ReadLine());
        while (a <= n)
    {
        if (a %2!=0)    
              
              Console.Write(a+=1);
    }
    
        
        Console.WriteLine("Четные числа");
    }
}
