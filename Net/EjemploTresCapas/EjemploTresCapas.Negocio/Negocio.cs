using EjemploTresCapas.Dato;
using EjemploTresCapas.Entidad;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EjemploTresCapas.Negocio
{
    public class Negocio
    {
        private bool _emailInvalido;
        private Datos _dao;

        public Negocio(string nombreArchivo)
        {
            this._dao = Datos.Instancia(nombreArchivo);
        }

        public List<Persona> Leer()
        {
            return this._dao.Leer();
        }

        public void Grabar(List<Persona> datos)
        {
            foreach (Persona item in datos)
            {
                if (string.IsNullOrWhiteSpace(item.Nombre))
                    throw new Exception("El nombre de la persona no puede ser vacio.");
                if (!string.IsNullOrEmpty(item.Email) && !IsValidEmail(item.Email))
                    throw new Exception(string.Format("El correo electrónico {0} no es válido", item.Email));
            }
            this._dao.Grabar(datos);
        }

        public bool IsValidEmail(string strIn)
        {
            _emailInvalido = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (_emailInvalido)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                _emailInvalido = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
