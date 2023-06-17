using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionSupermercado
{
    public class Cajero
    {
        private int IdCajero;
        private string Nombre;
        private Sucursal Sucursal;
        private List<Factura> facturas;

        public Cajero(int idCajero, string nombre, Sucursal sucursal)
        {
            IdCajero = idCajero;
            Nombre = nombre;
            Sucursal = sucursal;
            facturas = new List<Factura>();
        }
        public Factura CrearFactura(Cliente cliente)
        {
            Factura factura = new Factura(cliente);
            facturas.Add(factura);
            return factura;
        }
        public void AgregarProducto(Factura factura, Producto producto, int cantidad)
        {
            factura.AgregarItem(new ItemFactura(producto, cantidad));
        }
    }
}
