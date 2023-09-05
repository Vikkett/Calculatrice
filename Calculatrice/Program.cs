using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculatrcie");

            Console.WriteLine();
            Console.WriteLine("Write the first number");
            string firstNum = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Choose the operators");
            string operators = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Write the second number");
            string secondNum = Console.ReadLine();
           
            string operations = Console.ReadLine();
            int calculatrice = Convert.ToInt32(operators); 
            switch (calculatrice)
            {
                case 1:
                    Console.WriteLine("+");
                    break;
                case 2:
                    Console.WriteLine("-");
                    break;
                case 3:
                    Console.WriteLine("*");
                    break;
                case 4:
                    Console.WriteLine("/");
                    break;


            }

        }
    }
}
