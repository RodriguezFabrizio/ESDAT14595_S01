using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada
{
    internal class Vagon
    {
        public Vagon Sig {  get; set; }




        public int Dato { get; set; }

        public Vagon(Vagon sig, int dato)
        {
            Sig = null;
            Dato = dato;
        }
    }
}
