using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Document
    {
        public File file { get; set; }
        public PrintDocument printDocument{ get; set; }
        public SaveDocument saveDocument { get; set; }     
    }
}
