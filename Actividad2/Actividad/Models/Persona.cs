
namespace Actividad2.Models
{
    public class Persona
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }

        public Persona(int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }

        public string VerDatos()
        {
            return $"{this.Nombre}(DNI:{this.DNI})";
        }
    }
}
