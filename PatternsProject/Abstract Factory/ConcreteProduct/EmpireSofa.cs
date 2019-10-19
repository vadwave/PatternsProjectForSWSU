using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.ConcreteProduct
{
    class EmpireSofa : ISofa
    {
        public string Show()
        {
            return "диван в 'Ампирском' стиле";
        }
    }
}
