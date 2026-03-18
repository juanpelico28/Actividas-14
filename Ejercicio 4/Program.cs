using System.Collections.Generic;
using System.Globalization;

List<Libro> libros = new List<Libro>();
Console.Write("¿Cuantos Libros desea ingresar: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Libro l = new Libro();
    Console.WriteLine($"\n---- Ingreso De Datos Del Libro {i +1} -----");
    Console.Write("Titulo: ");l.Titulo = Console.ReadLine();
    Console.Write("Autor: ");l.Autor = Console.ReadLine();
    Console.Write("Categoria: "); l.Categoria = Console.ReadLine();
    Console.Write("Paginas: ");l.Paginas = int.Parse(Console.ReadLine());
    libros.Add(l);
}
Libro mayorPaginas = libros[0];

Console.WriteLine("\n--------- Listado de Libros -------");
foreach(Libro l in libros)
{
    l.MostrarDatos();
    if (l.Paginas > mayorPaginas.Paginas) { mayorPaginas = l; }
}
Console.WriteLine("\nEl Libro con Mayor Paginas Es: ");
mayorPaginas.MostrarDatos();
class Libro
{
    public string Titulo;
    public string Autor;
    public string Categoria;
    public int Paginas;

    public string Clasificar() { if (Paginas > 120) return "Extenso"; else if (Paginas > 80) return "Mediano"; else return "Corto"; }
    public void MostrarDatos()
    {
        Console.WriteLine($"Titulo: {Titulo} | Autor: {Autor} | Categoria: {Categoria} | Paginas: {Paginas} | Tipo de Libro: {Clasificar()}");

    }
}