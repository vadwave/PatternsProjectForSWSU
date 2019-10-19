﻿using PatternsProject.Abstract_Factory.IAbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory.ConcreteProduct
{
    class VictorianDesk : IDesk
    {
        public string Show()
        {
            return "стол в 'Викторианском' стиле";
        }
    }
}
