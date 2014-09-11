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
            int totalAmount;


            Console.Write("Ange totalsumma  : ");
            totalSum = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp : ");
            subTotal = double.Parse(Console.ReadLine());

            subTotal = (uint)Math.Round(totalSum);
            roundingOffAmount = totalSum - subTotal;

            Console.Write("KVITTO");

            Console.WriteLine("Totalt: {0:c}", totalSum);
            Console.WriteLine("Öresavrundning: {0:c}", roundingOffAmount);
            Console.Write("Att betala: ");
            




            
        }
    }
}
