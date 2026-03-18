
using System.Collections.Generic;

List<Venta> ventas = new List<Venta>();
Console.Write("¿Cuantas Ventas Desea Ingresar?: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Venta v = new Venta();
    Console.WriteLine($"\n----- Ingrese Datos De La Venta {i + 1}: ------ ");
    Console.Write("Nombre del Producto: "); v.Producto = Console.ReadLine();
    Console.Write("Precio: Q"); v.Precio = double.Parse(Console.ReadLine());
    Console.Write("Cantidad: "); v.Cantidad = int.Parse(Console.ReadLine());
    ventas.Add(v);    
}

double totalVendido = 0;
Console.WriteLine("\n--------- Listado De Ventas -----------");

foreach(Venta v in ventas)
{
    v.MostrarDatos();
    totalVendido += v.CalcularTotal();
}
Console.WriteLine($"\nEl Total De Las Ventas Es: Q{totalVendido:F2}");

class Venta
{
    public string Producto;
    public double Precio;
    public int Cantidad;

    public double CalcularSubTotal() { return Precio * Cantidad; }
    public double CalcularDescuento() { if (CalcularSubTotal() > 500) return CalcularSubTotal() * 0.10; else if (CalcularSubTotal() > 200) return CalcularSubTotal() * 0.05; else return 0; }
    public double CalcularTotal() { return CalcularSubTotal() - CalcularDescuento(); }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Producto} | Precio: Q{Precio} | Cantidad: {Cantidad} | SubTotal: Q{CalcularSubTotal():F2} | Descuento: Q{CalcularDescuento():F2} | Total a Pagar: Q{CalcularTotal():F2}");
    }
}

