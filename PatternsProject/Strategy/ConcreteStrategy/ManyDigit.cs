using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternsProject.Strategy
{
    class ManyDigit : IStrategy
    {
        public bool Check(string data)
        {
            double number = Double.Parse(data);
            return number > 99;
        }

        public string Name()
        {
            return "Многозначное число";
        }
    }
}
