using static System.Runtime.InteropServices.JavaScript.JSType;



using System;
using System.Collections.Generic;

List<Estudiante> estudiantes = new List<Estudiante>();
Console.Write("¿Cuantos Estudiantes desea ingresar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
Estudiante e = new Estudiante();
Console.WriteLine($"\n------ Ingrese datos del estudiante {i + 1} ----- ");
Console.Write("Nombre: "); e.Nombre = Console.ReadLine();
Console.Write("Nota 1: "); e.Nota1 = double.Parse(Console.ReadLine());
Console.Write("Nota 2: "); e.Nota2 = double.Parse(Console.ReadLine());
Console.Write("Nota 3: "); e.Nota3 = double.Parse(Console.ReadLine());
estudiantes.Add(e);
}
double sumarPromedio = 0;
Estudiante mejor = estudiantes[0];
Console.WriteLine("\n------- Listado de Estudiantes -------");
foreach (Estudiante e in estudiantes)
{
e.MostrarDatos();
sumarPromedio += e.CalcularPromedio();
if (e.CalcularPromedio() > mejor.CalcularPromedio()) { mejor = e; }
}
Console.WriteLine($"\nPromedio general del grupo: {sumarPromedio / estudiantes.Count:F2}");
Console.WriteLine("\nMejor Estudiantes: ");
mejor.MostrarDatos();



class Estudiante
{
    public string Nombre;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double CalcularPromedio()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }
    public string ObtenerEstado()
    {
        if (CalcularPromedio() >= 61) return "Aprobado";
        else return "Reprobado";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} | Promedio: {CalcularPromedio():F2} | Estado: {ObtenerEstado()}");
    }

}