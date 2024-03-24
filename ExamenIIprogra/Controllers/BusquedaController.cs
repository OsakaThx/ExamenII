using Microsoft.AspNetCore.Mvc;

public class BusquedaController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Buscar(string tipo, string cedula)
    {
        if (tipo == "Profesor")
        {
            var profesor = Lista.Profesores.Find(p => p.Cedula == cedula);
            return View("Resultado", profesor);
        }
        else if (tipo == "Estudiante")
        {
            var estudiante = Lista.Estudiantes.Find(e => e.Cedula == cedula);
            return View("Resultado", estudiante);
        }
        else
        {
            return View("Error");
        }
    }

    public IActionResult CrearEstudiante()
    {
        Estudiante.CrearEstudiante("901330986", "Joshua", 18, "ing", 4);
        return RedirectToAction("Index"); 
    }

    public IActionResult CrearProfesor()
    {
        Profesor.CrearProfesor("123456789", "Juan", "Pérez", "Matemáticas");
        return RedirectToAction("Index"); 
    }
}
