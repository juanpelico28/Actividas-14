
Dictionary<int, Estudiante> estudiantes = new Dictionary<int, Estudiante>();
Console.Write("¿Cuantos Estudiantes Desea Ingresar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{   
    Console.WriteLine($"\n------- Ingresar Datos Del Estudiante {i + 1}: ");
    Console.Write("Carnet: "); int carnet = int.Parse(Console.ReadLine());
    Estudiante estu = new Estudiante();
    Console.Write("Nombre: "); estu.Nombre = Console.ReadLine();
    Console.Write("Carrera: "); estu.Carrera = Console.ReadLine();
    Console.Write("Nota Final: "); estu.NotaFinal = double.Parse(Console.ReadLine());
    estudiantes[carnet] = estu;
}
Console.WriteLine("\n------------ Listado General ---------------");
foreach (KeyValuePair<int, Estudiante> item in estudiantes)
{
    Console.Write("Carnet: " + item.Key);
    item.Value.MostrarDatos();

}

class Estudiante
{
    public string Nombre;
    public string Carrera;
    public double NotaFinal;

    public string Estado() { if (NotaFinal > 61) return "Aprobado"; else return "Reprobado"; }
    public void MostrarDatos()
    {
        Console.WriteLine($"| Nombre: {Nombre} | Carrera: {Carrera} | Nota Fina: {NotaFinal} | Estado: {Estado}");
    }
}