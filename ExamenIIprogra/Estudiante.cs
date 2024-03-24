public class Estudiante
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set; }
    public int CantidadCursos { get; set; }

    public static void CrearEstudiante(string cedula, string nombre, int edad, string carrera, int cantidadCursos)
    {
        Estudiante nuevoEstudiante = new Estudiante
        {
            Cedula = cedula,
            Nombre = nombre,
            Edad = edad,
            Carrera = carrera,
            CantidadCursos = cantidadCursos
        };

        Lista.Estudiantes.Add(nuevoEstudiante);
    }
}
