using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class TextDocument
    {
        public string Name;
        public string Text;

        public abstract void Print();
    }
}
