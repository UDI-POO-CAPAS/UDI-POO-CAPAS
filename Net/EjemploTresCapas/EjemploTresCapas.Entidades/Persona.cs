
namespace EjemploTresCapas.Entidad
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Persona() : this (string.Empty,string.Empty,string.Empty)
        {

        }

        public Persona(string nombre, string telefono, string email)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Email = email;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2}", Nombre, Telefono, Email);
        }
    }
}
