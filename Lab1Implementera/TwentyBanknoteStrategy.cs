using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    //Strategy   TwentyBanknote = 20 kr-sedel
    public class TwentyBanknoteStrategy : IAlternativeValues
    {
        public void AlternativeValue(int value)
        {
            int numberOfTwentyBanknotes = value / 20;

            Console.WriteLine();
            Console.WriteLine("Du får " + numberOfTwentyBanknotes + " st 20 SEK-sedlar");
            Console.WriteLine();
            Console.WriteLine("Visa menyn och gör ett nytt val genom att trycka på valfri tangent.");
            Console.ReadKey();
            Console.WriteLine();
        }     

    }
}
