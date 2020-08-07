using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo012020
{
    class Program
    {
        static void Main(string[] args)
        {


            Rectangulo rectangulo = new Rectangulo();
            rectangulo.x1 = 10;
            rectangulo.y1 = 20;
            rectangulo.x2 = 0;
            rectangulo.y2 = 0;
            rectangulo.x3 = 0;
            rectangulo.y3 = 0;
            rectangulo.x4 = 0;
            rectangulo.y4 = 0;

            Console.WriteLine(rectangulo.x1.ToString());
            Console.WriteLine(rectangulo.y1.ToString());

            Console.Read();






            //Declaraciòn de variables
            string apellido = "Torrico";
            int Edad = 32;
            Console.WriteLine(apellido);
            Console.WriteLine(Edad.ToString());


            //Declaraciòn de objetos
            //Declarar el objeto Forma 1
            Persona persona = null;
            //Instancias el objeto
            persona = new Persona();
            //Asignas valores al objeto
            persona.Nombre = "Hector";
            persona.Apellido = "Rodriguez";

            Console.WriteLine(persona.Nombre);
            Console.WriteLine(persona.Apellido);


            //Escribir mensaje
            Console.WriteLine("Hellow world");
            
            //Pause
            //Console.Read();

        }
    }

   
}
