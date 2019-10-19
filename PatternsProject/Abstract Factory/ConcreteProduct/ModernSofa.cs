using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.ConcreteProduct
{
    // Конкретные продукты создаются соответствующими Конкретными Фабриками.
    class ModernSofa : ISofa
    {
        public string Show()
        {
            return "диван в стиле 'Модерн'";
        }
    }
}
