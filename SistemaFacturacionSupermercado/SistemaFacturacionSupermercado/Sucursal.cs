using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionSupermercado
{
    public class Sucursal
    {
        private int NumeroSucursal;
        private string Direccion;
        private List<Cajero> cajeros;
        private Inventario Inventario;

        public Sucursal(int numeroSucursal, string direccion)
        {
            NumeroSucursal = numeroSucursal;
            Direccion = direccion;
            cajeros = new List<Cajero>();
            Inventario = new Inventario();
        }
        public void AgregarCajero(Cajero cajero)
        {
            cajeros.Add(cajero);    
        }
        public void EliminarCajero(Cajero cajero)
        {
            cajeros.Remove(cajero); 
        }
        public Producto BuscarProducto(int codigo)
        {
            return Inventario.BuscarProducto(codigo);
        }
    }
}
