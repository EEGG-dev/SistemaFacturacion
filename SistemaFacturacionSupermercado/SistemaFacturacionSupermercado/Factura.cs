using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionSupermercado
{
    public class Factura
    {
        private int NumeroFactura;
        private DateTime fecha;
        private Cliente Cliente;
        private List<ItemFactura> items;

        public Factura(Cliente cliente)
        {
            Cliente = Cliente;
            items = new List<ItemFactura>();
        }
        public void AgregarItem(ItemFactura item)
        {
            items.Add(item);
        }
        public void EliminarItem(ItemFactura item)
        {
            items.Remove(item);
        }
        public double CalcularSubtotal()
        {
            double subtotal = 0;
            foreach (ItemFactura item in items)
            {
                subtotal += item.CalcularSubtotal();
            }
            return subtotal;
        }
        public double CalcularImpuestos()
        {
            double impuestos = 0;
            foreach (var item in items)
            {
                double impuestoItem = item.CalcularSubtotal() * 0.19;
                impuestos += impuestoItem;
            }
            return impuestos;
        }
        public double CalcularTotal()
        {
            double total = CalcularSubtotal() + CalcularImpuestos();
            return total;
        }
    }
}
