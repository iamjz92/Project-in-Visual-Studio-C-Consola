using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1
{
    class CantProducto
    {
        //atributos
        private Producto producto;
        private int cantidad;

        //propiedades
        public Producto Producto
        {
            get { return producto; }
        }
        public int Cantidad
        {
            get { return cantidad; }
        }

        //constructor
        public CantProducto(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }
        //modificador de cantidad de producto
        public void ModificarCantidad(int cantidadAAgregar)
        {
            this.cantidad = this.cantidad + cantidadAAgregar;
        }

    }
}
