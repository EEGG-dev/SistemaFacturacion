using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionSupermercado
{
    public class Inventario
    {
        private List<Producto> productos;

        public Inventario() 
        {
            productos = new List<Producto>();
        }
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public void EliminarProducto(Producto producto) 
        {
            productos.Remove(producto);
        }

        public Producto BuscarProducto(int codigo)
        {
            return productos.FirstOrDefault(p => p.GetCodigo() == codigo);
        }
    }
}
