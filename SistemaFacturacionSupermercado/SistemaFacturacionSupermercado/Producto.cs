using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacionSupermercado
{
    public class Producto
    {
        private int Codigo;
        private string Descripcion;
        private double Precio;
        private int Stock;

        public Producto(int codigo, string descripcion, double precio, int stock)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }
        public int GetCodigo()
        {
            return Codigo;
        }

        public string GetDescripcion()
        {
            return Descripcion;
        }
        public double GetPrecio()
        {
            return Precio;
        }
        public int GetStock()
        {
            return Stock;
        }
        public void ActualizarStock(int cantidad)
        {
            Stock += cantidad;
        }
        
    }
}
