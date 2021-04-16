using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasReproductor.listaCircularEj
{
    class NodoCir
    {
        public String dato;
        public NodoCir enlace;

        public NodoCir(String entrada)
        {
            dato = entrada;
            enlace = this; // se apunta asímismo

        }
    }
}