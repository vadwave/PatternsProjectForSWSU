using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.ConcreteProduct
{
    class VictorianSofa : ISofa
    {
        public string Show()
        {
            return "диван в 'Викторианском' стиле";
        }
    }
}
