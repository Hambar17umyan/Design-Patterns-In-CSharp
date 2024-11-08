using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Factory_Method
{
    public class WordDocument : TextDocument
    {
        public override void Print()
        {
            Console.WriteLine($"Printed the file {Name}.docx.:\n" + Text + new string('-', 25));
        }
    }
}
