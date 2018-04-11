using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvnPersonalRegister
{
    class Program
    {
        /*
         * 1. Registret skall kunna ta emot och lagra anställda med namn och lön via konsolen.
         * 2. Programmet skall kunna skriva ut registret i en konsol. 
         * 
         * Uppgift 1: Vilka klasser bör ingå i programmet? 
         *      Klasser: UI, Employee, EmployeeRegister
         * Uppgift 2: Vilka properties och metoder bör ingå i dessa klasser? 
         */



        static void Main(string[] args)
        {
            EmployeeRegistry employeeRegistry = new EmployeeRegistry();
            PrintMainMenu();
            mainLoop(employeeRegistry);

        }

        private static void mainLoop(EmployeeRegistry employeeRegistry)
        {
            bool stopProgram = false;
            do
            {
                int answer = UI.AskForInt("\nAnge kommando");

                switch (answer)
                {
                    case 0:
                        Console.WriteLine("Du har valt att avsluta programmet!");
                        stopProgram = true;
                        break;
                    case 1:
                        employeeRegistry.AddEmployeesAndSalary();
                        break;
                    case 2:
                        employeeRegistry.PrintEmployeeRegistry();
                        break;
                    case 3:
                        employeeRegistry.PrintAvgSalaryAndEmployees();
                        break;
                    case 4:
                        employeeRegistry.DeleteEmployee();
                        break;
                    case 9:
                        PrintMainMenu();
                        break;
                    default:
                        Console.WriteLine($"Angivet kommando finns ej {answer}");
                        break;
                }
            } while (!stopProgram);
        }

        private static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("==========================================================================");
            Console.WriteLine("*            MAIN MENU (Personalregister)                                *");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("* Tillgängliga kommandon:                                                *");
            Console.WriteLine("*           0: Avsluta programmet                                        *");
            Console.WriteLine("*           1: Mata in nya personer med lön (avsluta med 0)              *");
            Console.WriteLine("*           2: Skriv ut personalregistret                                *");
            Console.WriteLine("*           3: Skriv ut snittlön + personal                              *");
            Console.WriteLine("*           4: Ta bort person från personalregistret                     *");
            Console.WriteLine("*           9: Skriv ut huvudmenyn                                       *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("==========================================================================");
        }
    }
}
