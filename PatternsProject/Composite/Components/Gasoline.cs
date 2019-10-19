using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Composite.Components
{
    class Gasoline : Component
    {
        public override string Operation()
        {
            return "на бензине";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
