﻿
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшееЗадача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3



/*Console.Write("Input a first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int n2 = Convert.ToInt32(Console.ReadLine());
if(n1>n2)
    Console.WriteLine("n1=max");
else
    Console.WriteLine("n2=max");
    
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*Console.Write("Input a first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a three number:");
int n3 = Convert.ToInt32(Console.ReadLine());

 if (n1 >= n2)
 {
    if (n3 >= n1)
    {
      Console.WriteLine("max = n3");
    }
    else
    {
       Console.WriteLine("max = n1");
    }
 }
 else
 {
    if (n3 >= n2)
    {
       Console.WriteLine("max = n3");
    }
    else
    {
       Console.WriteLine("max = n2");
    }
 }

*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

/*Console.Write("Input a first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
if (n1 % 2 == 0)
 
            {
 
                Console.Write("Введенное число является четным");
 
                Console.Read();
 
            }
 
            else
 
            {
 
                Console.Write("Введенное число нечетное");
 
                Console.Read();
 
            }
            */

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*Console.Write("Input a first number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;


while(current <= number)
    {
        if(current % 2 ==0)
        Console.Write(current + ", ");
        current ++;
    }

