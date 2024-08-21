using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Persona
    {

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string NombresCompletos { get; set; }

        string validarEdad() { 
            if (Edad < 18 && Edad > 0) {
                return "Menor de Edad";
            } else if (Edad >= 18)
            {
                return "Mayor de edad";
            }
            return "Digitar un numero valido";
        }

        public void AsignarNombreCompleto() {
            NombresCompletos = Nombre + " " + Apellidos; 
        }
        
    }
}
