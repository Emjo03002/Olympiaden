using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Skriv in ditt tio siffriga personnummer och få ut det i tolvsiffrig form.");
            string personnummer = Console.ReadLine();
            
            string personnummer2 = personnummer.Substring(2,9);
            Console.WriteLine(personnummer2);
            int ref1 = 20;
            int ref2 = 10;
            if (personnummer.Contains('-')) 
            {
              
              personnummer= personnummer.Substring(0,2);
              
                int personnummer12 = int.Parse(personnummer);
                if (personnummer12 > ref1)
                    Console.WriteLine("19" + personnummer12+personnummer2.Remove(4,1));
                else if(personnummer12 < ref2 )
                    Console.WriteLine("200" + personnummer12+personnummer2.Remove(4,1));
                else
                   Console.WriteLine("20"+ personnummer12+ personnummer2.Remove(4,1));
            }
            else
            {
                personnummer=personnummer.Substring(0,2);
                int personnummer18 = int.Parse(personnummer);
                if (personnummer18 < ref1)
                    Console.WriteLine("19" + personnummer18+ personnummer2.Remove(4,1));
                else
                    Console.WriteLine("18" + personnummer18+ personnummer2.Remove(4,1));
            }


  }
}