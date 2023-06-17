using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionSupermercado
{
    public class Cliente
    {
        private int IdCliente;
        private string Nombre;
        private string Direccion;

        public Cliente(int idCliente, string nombre, string direccion)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Direccion = direccion;
        }
        public int GetIdCliente()
        {
            return IdCliente;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetDireccion()
        {
            return Direccion;
        }
    }
}
