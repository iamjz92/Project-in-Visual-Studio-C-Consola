using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    abstract class Donacion
    {
        //atributos
        private DateTime fecha;
        private Centro centro;

        //properties
        public DateTime Fecha
        {
            get { return fecha; }
        }

        public Centro Centro
        {
            get { return centro; }
        }

        //constructor
        public Donacion(Centro centro)
        {
            this.fecha = DateTime.Now;
            this.centro = centro;
        }
    }
}
