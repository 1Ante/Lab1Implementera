using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    //Ingår i Factory Method och är även Singleton. Bara en instans skapas.
    public sealed class TwoHundered : IValues
    {
        //räknare för att testa att bara en instans skapas/finns
        private static int counter = 0;
        private static TwoHundered instance = null;

        public static TwoHundered GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new TwoHundered();
                //Console.WriteLine(counter + " instance.");
                return instance;
            }
        }

        private TwoHundered()
        {
            counter++;
            //Console.WriteLine("TwoHundered has " + counter.ToString() + " instance");
        }
        public int GetValue()
        {
            return 200;
        }
    }
}
