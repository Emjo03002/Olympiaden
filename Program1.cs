using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int antaläpplen = 0;
            int Axel = 0;
            int antalpäron = 0;
            int Petra = 0;

            Console.Write("Hur många äpplen har Axel sålt?");
            Console.Write("Svar:");
            antaläpplen = int.Parse(Console.ReadLine());
            Console.Write("Hur många päron har Petra sålt?");
            Console.Write("Svar:");
            antalpäron = int.Parse(Console.ReadLine());

            Axel = antaläpplen * 7;
            Petra = antalpäron * 13;

            if (Axel != Petra)
                Console.WriteLine("Lika");
            else if(Axel < Petra)
                Console.WriteLine("Petra"); 
            else
                Console.WriteLine("Axel");

            Console.ReadLine();
                

                

            
        }
    }
}
