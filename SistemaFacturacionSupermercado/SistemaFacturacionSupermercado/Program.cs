using SistemaFacturacionSupermercado;

public class Program
{
    public static void Main(string[] args)
    {
        Supermercado supermercado = new Supermercado();

        Sucursal Nevada = new Sucursal(1, "Direccion 1");
        Sucursal LaPaz = new Sucursal(2, "Direccion 2");

        supermercado.AgregarSucursal(Nevada);
        supermercado.AgregarSucursal(LaPaz);

        Cajero cajero1 = new Cajero(1, "Cajero 1", Nevada);
        Cajero cajero2 = new Cajero(2, "Cajero 2", LaPaz);

        Nevada.AgregarCajero(cajero1);
        LaPaz.AgregarCajero(cajero2);

        Cliente cliente1 = new Cliente(1, "Hernan Nuñez", "Calle 5 # 6 - 92, La victoria");
        Cliente cliente2 = new Cliente(2, "Luis Adolfo Echeverri", "Calle 3 # 3 - 25, ");

        Producto producto1 = new Producto(1, "Arroz", 5000, 100);
        Producto 
    }
}