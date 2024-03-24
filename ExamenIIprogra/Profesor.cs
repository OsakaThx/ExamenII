public class Profesor
{
    public string Cedula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string AreaConocimiento { get; set; }

    public static void CrearProfesor(string cedula, string nombre, string apellido, string areaConocimiento)
    {
        Profesor nuevoProfesor = new Profesor
        {
            Cedula = cedula,
            Nombre = nombre,
            Apellido = apellido,
            AreaConocimiento = areaConocimiento
        };

        Lista.Profesores.Add(nuevoProfesor);
    }
}
