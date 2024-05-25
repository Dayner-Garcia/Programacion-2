namespace Capitulo_1_Introduccion.Tarea_Introduccion
{
    internal class Administrativo : Empleado
    {
        private string area {  get; set; }
        public Administrativo(string nombre, int edad, string cedula, string correo, int empleadoID, string puesto, int sueldo, bool activo, string fechaContratacion, string area) : base(nombre, edad, cedula, correo, empleadoID, puesto, sueldo, activo, fechaContratacion)
        {
        }
    }
}
