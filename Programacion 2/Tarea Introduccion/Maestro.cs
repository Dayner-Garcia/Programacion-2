namespace Capitulo_1_Introduccion.Tarea_Introduccion
{
    internal class Maestro : Docente
    {
        private string carrera {  get; set; }
        public Maestro(string nombre, int edad, string cedula, string correo, int empleadoID, string puesto, int sueldo, bool activo, string fechaContratacion, string tipoDocente = "Maestro", string carrera) : base(nombre, edad, cedula, correo, empleadoID, puesto, sueldo, activo, fechaContratacion, tipoDocente)
        {
            this.carrera = carrera;
        }
    }
}

