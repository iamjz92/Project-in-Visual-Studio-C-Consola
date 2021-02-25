using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class DeProducto : Donacion
    {
        //parametros
        private List<CantProducto> cantProducto = new List<CantProducto>();

        //properties
        public List<CantProducto> Productos
        {
            get { return cantProducto; }
        }

        //constructor
        public DeProducto(Centro centro, Producto producto, int cantidad ) : base(centro)
        {
            cantProducto.Add(new CantProducto(producto, cantidad));
        }

        /*public override bool Equals(object obj)
        {
            bool esUnico = false;
            if(obj!=null && obj is DeProducto)
            {
                DeProducto deProducto = (DeProducto)obj;
                esUnico=
            }
            return esUnico;
        }*/

        public void AgregarProductoCantidad(Producto producto, int cantidad)
        {
            CantProducto productoCantidad = new CantProducto(producto, cantidad);
            if(BuscarProductoCantidad(producto))
            {
                productoCantidad.ModificarCantidad(cantidad);
            }
            else
            {
                this.cantProducto.Add(productoCantidad);
            }
        }

        private bool BuscarProductoCantidad(Producto producto)
        {
            bool encontre = false;
            int i = 0;
            while(i<this.cantProducto.Count && encontre == false)
            {
                if (cantProducto[i].Producto.Equals(producto))
                {
                    encontre = true;
                }
                i++;
            }
            return encontre;
        }
    }
}
