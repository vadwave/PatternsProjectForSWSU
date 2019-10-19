using PatternsProject.Abstract_Factory.ConcreteProduct;
using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory
{
    // Конкретная Фабрика производит семейство продуктов одной вариации. Фабрика
    // гарантирует совместимость полученных продуктов.  Обратите внимание, что
    // сигнатуры методов Конкретной Фабрики возвращают абстрактный продукт, в то
    // время как внутри метода создается экземпляр  конкретного продукта.
    class Modern : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public IDesk CreateDesk()
        {
            return new ModernDesk();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

    }
}
