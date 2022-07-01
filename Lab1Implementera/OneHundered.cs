using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    //Ingår i Factory Method och är även Singleton. Bara en instans skapas.
    public sealed class OneHundered : IValues
    {
        //räknare för att testa att bara en instans skapas/finns
        private static int counter = 0;
        private static OneHundered instance = null;

        public static OneHundered GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new OneHundered();
                //Console.WriteLine(counter + " instance.");
                return instance;
                
            }
        }
        
        private OneHundered()
        {
            counter++;
            //Console.WriteLine("Onehundered has " + counter.ToString() + " instance");
        }
        
        public int GetValue()
        {
            return 100;
        }
    }
}
