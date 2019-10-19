using PatternsProject.Abstract_Factory.ConcreteProduct;
using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.ConcreteFactory
{
    // Каждая Конкретная Фабрика имеет соответствующую вариацию продукта.
    class Empire : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new EmpireChair();
        }

        public IDesk CreateDesk()
        {
            return new EmpireDesk();
        }

        public ISofa CreateSofa()
        {
            return new EmpireSofa();
        }
    }
}
