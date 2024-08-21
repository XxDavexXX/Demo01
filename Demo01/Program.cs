using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Dave";
            persona1.Apellidos = "Santivañez Munguia";
            persona1.Edad = 21;

            persona1.AsignarNombreCompleto();

            Persona persona2 = new Persona {
                Nombre = "David",
                Edad = 21
            };

            Estudiante estudiante = new Estudiante { 
                Nombre = "Dave",
                Apellidos = "Santivañez",
                Codigo = 20
            };

            Profesor profesor1 = new Profesor
            {
                Nombre = "Dave",
                Apellidos = "Santivañez",
                Sueldo = 4500
            };

            profesor1.CalcularSueldoNeto();
            Console.WriteLine(profesor1.Sueldo);



            //Console.WriteLine(persona1.NombresCompletos);

            Triangulo triangulo1 = new Triangulo();
            triangulo1.Base = 5;
            triangulo1.Altura = 4;
            triangulo1.MostrarArea();
            //Console.WriteLine(triangulo1.Area);
            Console.Read();
        }
    }
}
