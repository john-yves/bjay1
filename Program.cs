using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayment
{
    class Program
    {
        static void Main(string[] args)
        {
            string emp_name, Notification;
            int working_days = 0,shift=0,
                            n = 0,
                            enumber;

            double bonus = 0, tax=0,
                            daily_rate = 0;

            double total_deductions = 0,
                            gross_sal = 0,
                            net_sal = 0;
            do
            {
                Console.Clear();
                Console.Write("\t\t EMPLOYEE'S PAYMENT PROGRAM");
                Console.Write("\n\n");
                Console.Write("\t\t Enter Employee's Name :");
                emp_name = Console.ReadLine();
                Console.Write("\t\t Enter employee number:");
                enumber = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("\t\t Choose Empoyee's Shift: ", shift);
                Console.WriteLine("\t\t Enter 1 for Monthly salary", shift);
                Console.WriteLine("\t\t Enter 2 for Hourly basis", shift);
                Console.WriteLine("\t\t Enter 3 for Evening Basis", shift);
                shift = Convert.ToInt32(Console.ReadLine());
                if (shift == 1)
                {
                    Console.Write("\t\t enter your gross salary:\n");
                    gross_sal = Convert.ToInt32(Console.ReadLine());
                    total_deductions = (0.03 + 0.18);
                    Console.WriteLine("Total Deductions : {0}\n", total_deductions);
                    
                    net_sal = (gross_sal - total_deductions);
                    Console.WriteLine("YOUR MONTHLY SALARY:{0}\n", net_sal);
                }
                else if (shift == 2)
                {
                    Console.Write("Enter working days: ");
                    working_days = Convert.ToInt16(Console.ReadLine());
                    total_deductions = 0.18;
                    Console.WriteLine("Total Deductions : {0}.", total_deductions);
                    Console.Write("Enter Daily Salary Rate : ");
                    daily_rate = Convert.ToDouble(Console.ReadLine());
                    gross_sal = (working_days * daily_rate);
                    net_sal = (gross_sal - total_deductions);
                    Console.WriteLine("Net sal:{0}.", net_sal);
                    Console.WriteLine("your hourly basis salary");
                }
                else if (shift == 3)
                {
                    Console.Write("Enter working days: ");
                    working_days = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter Daily Salary Rate : ");
                    daily_rate = Convert.ToDouble(Console.ReadLine());
                    gross_sal = (working_days * daily_rate);
                    bonus = (gross_sal * 0.15) / 100;
                    total_deductions = (0.18 + bonus);
                    Console.WriteLine("Total Deductions :{0}\n", total_deductions);
                    
                    net_sal = (gross_sal - total_deductions);
                    Console.WriteLine("Net sal:{0}\n", net_sal);
                }
                else
                {
                    Console.WriteLine("wrong choice");
                }
                Console.Write("ANY MORE? Y/N : ");
                Notification = Console.ReadLine();
                if (Notification == "y" || Notification == "Y")
                {
                    continue;
                }
                else if (Notification == "n" || Notification == "N")
                {
                    Console.Write("\n\n");
                    Console.Write("Thank You For Using This Software.");
                    Console.Write("\n\n");
                    break;
                }
            } while (n == 0);
            Console.ReadLine();
        }
    }
}


