namespace Capitulo_1_Introduccion.Tarea_Introduccion
{
    public abstract class MiembroComunidad
    {
        private string nombre {  get; set; }
        private int edad {  get; set; }
        private string cedula { get; set; }
        private string correo { get; set; }

        public MiembroComunidad(string nombre, int edad, string cedula, string correo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.cedula = cedula;
            this.correo = correo;
        }
    }
}
