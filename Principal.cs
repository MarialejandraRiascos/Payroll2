﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Est_Evaluación
{
    internal class Principal
    {
        public static void Main(string[] args)
        {

            while(true)
            {


                try
                {
                    Program invoice = new Program();
                    Console.WriteLine("Payroll Program");
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. Exit Payroll Program");
                    string opc = Console.ReadLine();
                    int Opc1 = 1;
                    switch (opc)
                    {
                        case "1":

                            do
                            {
                                invoice.CalculatePayroll();
                                invoice.ToPrintDate();
                                Console.WriteLine("1. Add new employee");
                                Console.WriteLine("2. Exit Payroll Program");

                                Opc1 = int.Parse(Console.ReadLine());


                                Console.WriteLine("Invalid data");


                                Console.Clear();
                            }
                            while (Opc1 != 2);

                            Console.WriteLine();

                            break;
                        case "2":

                            break;
                            



                    }
                }
                catch (Exception ex)


                {
                    Console.WriteLine("Leaving the program");
                }
            }
        }

        
    }
}