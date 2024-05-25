namespace Capitulo_1_Introduccion.Tarea_Introduccion
{
    internal class Docente : Empleado
    {
        private string tipoDocente { get; set; }
        public Docente(string nombre, int edad, string cedula, string correo, int empleadoID, string puesto, int sueldo, bool activo,string fechaContratacion, string tipoDocente) : base(nombre, edad, cedula, correo, empleadoID, puesto, sueldo, activo, fechaContratacion)
        {
            this.tipoDocente = tipoDocente;
        }
    }
}
