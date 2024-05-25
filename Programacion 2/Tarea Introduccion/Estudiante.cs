namespace Capitulo_1_Introduccion.Tarea_Introduccion
{
    internal class Estudiante : MiembroComunidad
    {
        private int estudianteID {  get; set; }
        private string matricula {  get; set; }
        private string carrera { get; set; }
        private Boolean activo { get; set; }
        public Estudiante(string nombre, int edad, string cedula, string correo, int estudianteID, String matricula, string carrera) : base(nombre, edad, cedula, correo)
        {
            this.estudianteID = estudianteID;
            this.matricula = matricula;
            this.carrera = carrera;
            this.activo = true;
        }
    }
}
