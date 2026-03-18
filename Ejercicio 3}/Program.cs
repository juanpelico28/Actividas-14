
using System.Collections.Generic;

List<Empleado> empleados = new List<Empleado>();
Console.Write("¿Cuantos Empleado desea ingresar?: ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    Empleado emp = new Empleado();
    Console.WriteLine($"\n------Ingrese Datos Del Empleado {i + 1} ------- ");
    Console.Write("Nombre: ");emp.Nombre = Console.ReadLine();
    Console.Write("Puesto: "); emp.Puesto = Console.ReadLine();
    Console.Write("Salario: "); emp.Salario = double.Parse(Console.ReadLine());
    empleados.Add(emp);
}

double SalarioMasBono = 0;
Console.WriteLine("\n------- Listado de Empleados -------");
foreach(Empleado emp in empleados)
{
    emp.MostrarDatos();
}


class Empleado
{
    public string Nombre;
    public string Puesto;
    public double Salario;

    public double CalcularSalarioAnual() {  return Salario * 12; }
    public double CalcularBono() { if (Salario >= 8000) return CalcularSalarioAnual() * 0.15; else return CalcularSalarioAnual() * 0.08; }
    public string Clasificacion() { if (Salario >= 8000) return "Salario Alto"; else if (Salario >= 4000) return "Salario Medio"; else return "Salario Bajo";}
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} | Puesto: {Puesto} | Salario: {Salario} | Salario Anual: {CalcularSalarioAnual()} | Bono: {CalcularBono()} | Clasificación: {Clasificacion()}");
    }
}