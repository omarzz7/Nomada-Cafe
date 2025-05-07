using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomdad_Cafe
{
    public class Producto
    {
        public int Cantidad { get; set; }
        public String NombreProducto { get; set; }
        public double Precio { get; set; }

        public Producto(int cantidad, string nombreproducto, double precio)
        {
            Cantidad = cantidad;
            NombreProducto = nombreproducto;
            Precio = precio;

            cantidad = 1;
        }
    }
}
