using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Profesor: Persona
    {
        public double Sueldo { get; set; }

        public void CalcularSueldoNeto() {
            if (Sueldo >= 0 && Sueldo < 2000) { Sueldo = Sueldo - Sueldo*0.8; } 
            else if(Sueldo >= 2000 && Sueldo < 5000) { Sueldo = Sueldo - Sueldo * 0.14; } 
            else if (Sueldo >= 5000 && Sueldo < 7000) { Sueldo = Sueldo - Sueldo * 0.30; }
        }
    }
}
