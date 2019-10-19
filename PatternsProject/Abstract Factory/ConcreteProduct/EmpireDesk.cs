using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.ConcreteProduct
{
    class EmpireDesk: IDesk
    {
        public string Show()
        {
            return "стол в 'Ампирском' стиле";
        }
    }
}
