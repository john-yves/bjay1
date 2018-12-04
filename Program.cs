using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int c;
               var operation1 = new calculate();
               Console.WriteLine("enter first number");
               double num1 = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("enter second number");
               double num2 = Convert.ToDouble(Console.ReadLine());
               Console.Write("choose any operator continue:\n\n");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. substract");
            Console.WriteLine("3. Divide");
            Console.WriteLine("4. Multiply\n\n\n\n\n");
            int C = Convert.ToInt16(Console.ReadLine());
            
            if (C == 1)
            {
                operation1.Add(num1, num2);
                Console.WriteLine("the result of :{0} and {1}is equal to {2}", num1, num2, operation1.Add(num1, num2));
            }
  else if( C==2)
            {
                operation1.Substract(num1, num2);
                Console.WriteLine("the result of :{0} and {1}is equal to {2}", num1, num2, operation1.Substract(num1, num2));
            }
            else if (C == 3)
            {
                operation1.Divide(num1, num2);
                Console.WriteLine("the result of :{0} and {1}is equal to {2}", num1, num2, operation1.Divide(num1, num2));
            }
            else if (C == 4)
            {
                operation1.Multiply(num1, num2);
                Console.WriteLine("the result of : {0} and {1}is equal to {2}", num1, num2, operation1.Multiply(num1, num2));
            }
            else
            {
                Console.WriteLine("impossible calculation");
            }
            Console.ReadKey();
               

   
          
         }




    }
}
