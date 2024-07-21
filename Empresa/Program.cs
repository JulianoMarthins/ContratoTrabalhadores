using Empresa.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of employees: ");
            int num = int.Parse(Console.ReadLine());

            List<Employee> employee = new List<Employee>();

            
            for(int i = 0; i < num; i++)
            {

                Console.Write("\nOutsourced? [y/n]: ");
                char opc = char.Parse(Console.ReadLine().ToLower());
                
                if (opc != 'n' && opc != 'y')
                {
                    Console.WriteLine("Você digitou um valor inválido");
                    i--;
                    continue;
                }

                Console.Write("\nName: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());


                if (opc == 'y')
                {
                    Console.Write("\nAdditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    employee.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                    Console.WriteLine("Registrador tercerizado");
                }

                else if (opc == 'n')
                {
                    employee.Add(new Employee(name, hours, valuePerHour));
                    Console.WriteLine("Empregado CLT");
                }               
            }

            Console.WriteLine("Payment: \n");

            foreach (Employee emp in employee)
            {
                Console.WriteLine(emp.ToString());
            }

                      
           
        }
    }
}
