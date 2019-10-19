using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternsProject.Strategy.ConcreteStrategy
{
    class DoubleDigit : IStrategy
    {
        public bool Check(string data)
        {
            double number = Double.Parse(data);
            return number > 9 && number < 100;
        }

        public string Name()
        {
            return "Двухзначное число";
        }
    }
}
