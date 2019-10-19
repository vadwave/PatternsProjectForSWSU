using System;
using System.Collections.Generic;
using System.Text;
using PatternsProject.Abstract_Factory.ConcreteProduct;
using PatternsProject.Abstract_Factory.IAbstractProduct;

namespace PatternsProject.Abstract_Factory.ConcreteFactory
{
    class Victorian : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public IDesk CreateDesk()
        {
            return new VictorianDesk();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
