using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Economica : Donacion
    {
        //atributos
        private double monto;

        //properties
        public double Monto
        {
            get { return monto; }
        }

        //constructor
        public Economica(Centro centro, double monto) : base(centro)
        {
            this.monto = monto;
        }
    }
}
