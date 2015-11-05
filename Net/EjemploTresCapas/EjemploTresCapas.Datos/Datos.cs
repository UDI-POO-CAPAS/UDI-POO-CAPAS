using EjemploTresCapas.Entidad;
using System.Collections.Generic;
using System.IO;

namespace EjemploTresCapas.Dato
{
    public class Datos
    {

        private static Datos datos;
        public string NombreArchivo { get; private set; }

        public static Datos Instancia(string nombreArchivo)
        {
            if (datos == null)
                datos = new Datos(nombreArchivo);
            return datos;
        }

        private Datos()
        {
        }

        private Datos(string nombreArchivo)
        {
            this.NombreArchivo = nombreArchivo;
        }

        public List<Persona> Leer()
        {
            List<Persona> datos = new List<Persona>();

            if (File.Exists(NombreArchivo))
            {
                using (StreamReader sr = new StreamReader(NombreArchivo))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] arrDatos = sr.ReadLine().Split(';');
                        datos.Add(new Persona(arrDatos[0], arrDatos[1], arrDatos[2]));
                    }
                    sr.Close();
                }
            }
            else
                throw new FileNotFoundException("No se encontró el archivo " + NombreArchivo);

            return datos;
        }

        public void Grabar(List<Persona> datos)
        {
            using (StreamWriter sr = new StreamWriter(NombreArchivo, false))
            {
                foreach (Persona item in datos)
                    sr.WriteLine(item.ToString());
                sr.Flush();
                sr.Close();
            }
        }
    }
}
