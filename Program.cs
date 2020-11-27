using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt tio siffriga personnummer och få ut det i tolvsiffrig form.");
            string personnummer = Console.ReadLine();
            
            
            long född1900 = 2000000000;
            if (personnummer.Contains('-')) 
            {
                long personnummer12 = long.Parse(personnummer);
                personnummer.Remove(7);
                if (personnummer12 > född1900)
                    Console.WriteLine("19" + personnummer12);
                else
                    Console.WriteLine("20" + personnummer12);
            }
            else
            {
                long personnummer18 = long.Parse(personnummer);
                if (personnummer18 < född1900)
                    Console.WriteLine("19" + personnummer18);
                else
                    Console.WriteLine("18" + personnummer18);
            }



        }
    }
}
