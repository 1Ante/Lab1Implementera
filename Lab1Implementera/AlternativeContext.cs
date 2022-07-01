using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Implementera
{
    //Strategy
    public class AlternativeContext
    {
        private IAlternativeValues AlternativeValues;
        
        public void SetAlternativeStrategy(IAlternativeValues strategy)
        {
            this.AlternativeValues = strategy;
        }
        public void AlternativeValue(int value)
        {
            AlternativeValues.AlternativeValue(value);
        }
    }
}
