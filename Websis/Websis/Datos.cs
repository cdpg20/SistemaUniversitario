using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websis
{
    public class Datos
    {
        string nombreDoc;
        string nombreCarr;

        public Datos(string nombreDoc, string nombreCarr)
        {
            this.nombreCarr = nombreCarr;
            this.nombreDoc = nombreDoc;
        }
    }
}
