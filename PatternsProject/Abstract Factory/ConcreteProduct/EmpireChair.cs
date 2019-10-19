using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.ConcreteProduct
{
    class EmpireChair : IChair
    {
        public string Show()
        {
            return "кресло в 'Ампирском' стиле";
        }
    }
}
