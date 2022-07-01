using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    //Strategy
    public class TenCoinStrategy : IAlternativeValues
    {
        public void AlternativeValue(int value)
        {
            int numberofTenCoins = value / 10;

            Console.WriteLine();
            Console.WriteLine("Du får " + numberofTenCoins + " st 10-kronor");
            Console.WriteLine();
            Console.WriteLine("Visa menyn och gör ett nytt val genom att trycka på valfri tangent.");
            Console.ReadKey();
            Console.WriteLine();            

        }
    }
}
