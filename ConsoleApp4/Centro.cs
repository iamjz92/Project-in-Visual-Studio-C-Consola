using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class Centro
    {
        //parametros
        private string nombre;
        private string direccion;
        private List<Donacion> donaciones = new List<Donacion>();
        private List<Voluntario> voluntarios = new List<Voluntario>();

        //properties
        public string Nombre
        {
            get { return nombre; }
        }
        public string Direccion
        {
            get { return direccion; }
        }

        //constructor
        public Centro(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
    }
}
