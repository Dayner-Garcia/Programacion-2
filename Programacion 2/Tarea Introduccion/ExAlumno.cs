namespace Capitulo_1_Introduccion.Tarea_Introduccion
{
    public class ExAlumno : MiembroComunidad
    {
        private int exAlumnoID {  get; set; }
        private Boolean activo { get; set; }
        private string carrera {  get; set; }
        public ExAlumno(string nombre, int edad, string cedula, string correo, int exAlumnoID, Boolean activo, string carrera) : base(nombre, edad, cedula, correo)
        {
            this.exAlumnoID = exAlumnoID;
            this.activo = false;
            this.carrera = carrera;
        }
    }
}