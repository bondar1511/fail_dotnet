﻿//  27: Напишите метод, который принимает на вход число и выдаёт сумму цифр 
//  в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


       int X = Concole.Writeline("Введите число: ");
       int sum=0;
      
            while (X > 0)
            {
 
                sum = sum + X % 10;
                 X = X /10 ;
               
              Concole.Writeline(sum);
            }
              
        
    