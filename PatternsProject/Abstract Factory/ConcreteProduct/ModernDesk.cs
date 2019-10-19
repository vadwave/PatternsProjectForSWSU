using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.ConcreteProduct
{
    // Конкретные Продукты создаются соответствующими Конкретными Фабриками.
    class ModernDesk : IDesk
    {
        public string Show()
        {
            return "стол в стиле 'Модерн'";
        }
    }
}
