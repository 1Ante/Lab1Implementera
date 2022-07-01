using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    //Factory Method
    public abstract class MoneyFactory
    {
        protected abstract IValues MakeMoney();

        public IValues CreateMoney()
        {
            return this.MakeMoney();
        }
    }
}
