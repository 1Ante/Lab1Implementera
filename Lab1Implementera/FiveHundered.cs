using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    //Ingår i Factory Method och är även Singleton. Bara en instans skapas.
    public class FiveHundered : IValues
    {
        //räknare för att testa att bara en instans skapas/finns
        private static int counter = 0;
        private static FiveHundered instance = null;

        public static FiveHundered GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new FiveHundered();
                //Console.WriteLine(counter + " instance.");
                return instance;
            }
        }

        private FiveHundered()
        {
            counter++;
            //Console.WriteLine("FiveHundered has " + counter.ToString() + " instance");
        }
        public int GetValue()
        {
            return 500;
        }
    }
}
