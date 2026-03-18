
using System.Collections.Generic;

List<Producto> productos = new List<Producto>();
Console.Write("¿Cuantos Productos desea ingresar?: ");
int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    Producto p = new Producto();
    Console.WriteLine($"\n------ Ingrese Datos Del Producto {i + 1} ------");
    Console.Write("Nombre: "); p.Nombre = Console.ReadLine();
    Console.Write("Precio: "); p.Precio = double.Parse(Console.ReadLine());
    Console.Write("Stock: "); p.Cantidad = int.Parse(Console.ReadLine());
    productos.Add(p);

}

double valorTotalInvetario = 0;
Producto mayorPrecio = productos[0];
Console.WriteLine("\n------- Listado De Los Productos -------");
foreach (Producto p in productos){
    p.MostrarDatos();
    valorTotalInvetario += p.CalcularValorTotal();
    if(p.Precio > mayorPrecio.Precio) { mayorPrecio = p; }
}
Console.WriteLine($"\nValor Total Del Inventario: Q{valorTotalInvetario:F2}");
Console.WriteLine($"\nProducto Con Mayor Precio Unitario: ");
mayorPrecio.MostrarDatos();
class Producto
{
    public string Nombre;
    public double Precio;
    public int Cantidad;

    public double CalcularValorTotal() { return Precio *  Cantidad; }
    public string EvaluarStock() { if (Cantidad == 5) return "Sin Existencia"; else if (Cantidad <= 5) return "Stock Bajo"; else return "Stock Suficiente"; }
    public void MostrarDatos ()
    {
        Console.WriteLine($"Nombre: {Nombre} | Precio: {Precio} | Stock: {Cantidad} | Total invertido: {CalcularValorTotal():F2} | Estado: {EvaluarStock()} ");
    }

}