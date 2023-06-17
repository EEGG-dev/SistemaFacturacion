namespace SistemaFacturacionSupermercado
{
    public class ItemFactura
    {
        private Producto Producto { get; }
        private int Cantidad { get; }
        private double PrecioUnitario { get; }

        public ItemFactura(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;    
            PrecioUnitario = producto.GetPrecio();
        }
        public Producto GetProducto()
        {
            return Producto;
        }
        public int GetCantidad()
        {
            return Cantidad;
        }
        public double GetPrecioUnitario()
        {
            return PrecioUnitario;
        }
        public double CalcularSubtotal()
        {
            double subtotal = Cantidad * PrecioUnitario;
            return subtotal;
        }
    }
}