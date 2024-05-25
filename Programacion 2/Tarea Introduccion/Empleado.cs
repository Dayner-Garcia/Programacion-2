namespace Capitulo_1_Introduccion.Tarea_Introduccion
{
    public class Empleado : MiembroComunidad
    {
        private int empleadoID {  get; set; }
        private string puesto { get; set; }
        private int sueldo { get; set; }
        private bool activo { get; set; }
        private string fechaContratacion { get; set; }
        public Empleado(string nombre, int edad, string cedula, string correo, int empleadoID, string puesto, int sueldo, bool activo, string fechaContratacion) : base(nombre, edad, cedula, correo)
        {
            this.empleadoID = empleadoID;
            this.puesto = puesto;
            this.sueldo = sueldo;
            this.activo = activo;
            this.fechaContratacion = fechaContratacion;
        }
    }
}