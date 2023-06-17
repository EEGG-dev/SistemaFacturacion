using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionSupermercado
{
    public class Supermercado
    {
        private List<Sucursal> sucursales;

        public Supermercado()
        {
            sucursales = new List<Sucursal>();
        }
        public void AgregarSucursal(Sucursal sucursal)
        {
            sucursales.Add(sucursal);
        }
        public void EliminarSucursal(Sucursal sucursal)
        {
            sucursales.Remove(sucursal);
        }
    }
}
