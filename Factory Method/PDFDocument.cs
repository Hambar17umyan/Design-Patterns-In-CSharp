using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class PDFDocument : TextDocument
    {
        public override void Print()
        {
            Console.WriteLine($"Printed the file {Name}.pdf.:\n" + Text + new string('-', 25));
        }
    }
}
