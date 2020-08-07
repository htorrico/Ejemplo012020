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
            rectangulo.x1 = 0;
            rectangulo.y1 = 0;
            rectangulo.x2 = 12;
            rectangulo.y2 = 0;
            rectangulo.x3 = 12;
            rectangulo.y3 = 4;
            rectangulo.x4 = 0;
            rectangulo.y4 = 0;


            Console.WriteLine(rectangulo.CalcularArea().ToString());

            Console.WriteLine(rectangulo.x1.ToString());
            Console.WriteLine(rectangulo.y1.ToString());

            int ResultadoSuma = 0;
            ResultadoSuma = rectangulo.Sumar(5, 4);

            int ResultadoSumaCoordenadas = 0;
            ResultadoSumaCoordenadas = rectangulo.SumarCoordenada();


            Console.WriteLine(ResultadoSuma.ToString());
            Console.WriteLine(ResultadoSumaCoordenadas.ToString());

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
