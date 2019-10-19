using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.IAbstractProduct
{
    // Каждый отдельный продукт семейства продуктов должен иметь базовый
    // интерфейс. Все вариации продукта должны реализовывать этот интерфейс.
    public interface ISofa
    {
        string Show();
    }
}
