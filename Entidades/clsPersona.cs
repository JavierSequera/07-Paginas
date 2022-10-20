namespace Entidades
{
    public class clsPersona
    {
        public string Nombre { get; set; }
        public string apellido { get; set; } 

        public clsPersona (String nombre, String apellido)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
        }

        public clsPersona()
        {
        }
    }
}