using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Composite.Components
{
    class Gas : Component
    {
        public override string Operation()
        {
            return "на газе";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
