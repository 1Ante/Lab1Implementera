using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    //Factory Method
    public class OneHunderedFactory : MoneyFactory
    {
        protected override IValues MakeMoney()
        {
            IValues value = OneHundered.GetInstance;
            return value;
        }        
    }
    public class TwoHunderedFactory : MoneyFactory
    {
        protected override IValues MakeMoney()
        {
            IValues value = TwoHundered.GetInstance;
            return value;
        }
    }
    public class FiveHunderedFactory : MoneyFactory
    {
        protected override IValues MakeMoney()
        {
            IValues value = FiveHundered.GetInstance;
            return value;
        }
    }
}
