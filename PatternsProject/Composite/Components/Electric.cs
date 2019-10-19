using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Composite.Components
{
    class Electric : Component
    {
        public override string Operation()
        {
            return "на электричестве";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
