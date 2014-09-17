using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Växelpengar - nivå A";

            double totalSum;
            int subTotal;
            double roundingOffAmount;
            double totalAmount;
            double cash;
            double cashBack;
            double fiveHundreds;
            double hundreds;
            double fifties;
            double twenties;
            double tens;
            double fives;
            double ones;
           

                Console.Write("Ange totalsumma  : ");
                totalSum = double.Parse(Console.ReadLine());

                Console.Write("Ange erhållet belopp : ");
                subTotal = int.Parse(Console.ReadLine());
                cash = subTotal;


            subTotal = (int)Math.Round(totalSum);
            roundingOffAmount = totalSum - subTotal;

            totalAmount = totalSum - roundingOffAmount;
            cashBack = cash - totalAmount;

            Console.WriteLine("KVITTO");
            
            Console.WriteLine("Totalt: {0:c}", totalSum);
            Console.WriteLine("Öresavrundning: {0:c}", roundingOffAmount);
            Console.WriteLine("Att betala: {0:c0}", totalAmount); 
            Console.WriteLine("Kontant: {0:c0} ", cash);
            Console.WriteLine("Tillbaka: {0:c0}", cashBack);



            fiveHundreds = cashBack / 500;
            hundreds = cashBack % 500;
            hundreds = hundreds / 100;
            fifties = cashBack % 100;
            fifties = fifties / 50;
            twenties = cashBack % 50;
            twenties = twenties / 20;
            tens = cashBack % 20;
            tens = tens / 10;
            fives = cashBack % 10;
            fives = fives / 5;
            ones = cashBack % 5;
            ones = ones / 1;


            Console.WriteLine("Antal 500-lappar: {0}", (int)fiveHundreds);
            Console.WriteLine("Antal 100-lappar: {0}", (int)hundreds);
            Console.WriteLine("Antal 50-lappar: {0}", (int)fifties);
            Console.WriteLine("Antal 20-lappar: {0}", (int)twenties);
            Console.WriteLine("Antal 10-kronor: {0}", (int)tens);
            Console.WriteLine("Antal 5-kronor: {0}", (int)fives);
            Console.WriteLine("Antal 1-kronor: {0}", (int)ones);

        }
    }
}