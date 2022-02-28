using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + b;
        }

        public virtual string GetName()
        {
            return "Calculator";
        }
    }

    public class ScientifiCalculator : Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public override string GetName()
        {
            return "scintificcalculator";
        }
    }
}
