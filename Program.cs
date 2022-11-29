using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 27.Возведите число n  в куб, используя следующую схему:
1^3 = 1;
2^3 = 3 + 5;
3^3 = 7 + 9 + 11;
4^3 = 13 + 15 + 17 + 19;
5^3 = 21 + 23 + 25 + 27 + 29…  */

namespace Lab_3_1_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int digit = n * n;
            int sum, up, down;            

            if (n % 2 == 0)
            {
                sum = 0;
                up = digit + 1;
                down = digit - 1;
            }
            else
            {                
                sum = digit;
                up = digit;
                down = digit;
            }            
            
            for (int i = 0; i < n / 2; i++)                
            {                
                up += 2;
                down -= 2;
                sum += up + down;                
            }
            
            Console.WriteLine($"Cube= {sum}");
            Console.ReadKey();
        }
    }
}
