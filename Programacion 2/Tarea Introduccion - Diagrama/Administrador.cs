namespace Capitulo_1_Introduccion.Tarea_Introduccion
{
    internal class Administrador : Docente
    {
        private string nivelAcceso;
        public Administrador(string nombre, int edad, string cedula, string correo, int empleadoID, string puesto, int sueldo, bool activo, string fechaContratacion, string tipoDocente, string nivelAcceso) : base(nombre, edad, cedula, correo, empleadoID, puesto, sueldo, activo, fechaContratacion, tipoDocente)
        {
            this.nivelAcceso = nivelAcceso;
        }
    }
}
