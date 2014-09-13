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
            double subTotal;
            double roundingOffAmount;
            double totalAmount;
            double cash;
            double cashBack;


            Console.Write("Ange totalsumma  : ");
            totalSum = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp : ");
            subTotal = double.Parse(Console.ReadLine());
            cash = subTotal;

            subTotal = (uint)Math.Round(totalSum);
            roundingOffAmount = totalSum - subTotal;

            totalAmount = totalSum - roundingOffAmount;
            cashBack = cash - totalAmount;

            Console.Write("KVITTO");

            Console.WriteLine("Totalt: {0:c}", totalSum);
            Console.WriteLine("Öresavrundning: {0:c}", roundingOffAmount);
            Console.WriteLine("Att betala: {0:c}", totalAmount); 
            Console.WriteLine("Kontant: {0:c} ", cash);
            Console.WriteLine("Tillbaka: {0:c}", cashBack);





        }
    }
}