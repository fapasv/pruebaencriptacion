using encriptacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encriptacion.Services
{
    public interface ICodificador
    {
        string Codificar(string mensaje);
    }
    public class ToMorse : ICodificador
    {
        public string Codificar(string mensaje)
        {
            return Salida(mensaje);
        }

        private string Salida(string mensaje) {
            var sb = new StringBuilder();
            foreach (var letra in mensaje.ToUpper())
            {
                if (Morse.Codificacion.ContainsKey(letra))
                {
                    sb.Append(Morse.Codificacion[letra]);
                }
            }
            return sb.ToString();
        }
    }
}
