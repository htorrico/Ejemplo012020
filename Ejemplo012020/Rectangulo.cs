using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo012020
{
    class Rectangulo
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        public int x4 { get; set; }
        public int y4 { get; set; }

        //Creando funciones
        public int Sumar(int a, int b)
        {
            return a + b;
        }
        public int SumarCoordenada()
        {
            return x1 + y1;
        }

        //Funciones de forma natural
        private double CalcularDistancia(int x1,int y1, int x2, int y2)
        {
            double distancia = 0;
            distancia = Math.Sqrt(
                                  Math.Pow((x2 - x1), 2) +
                                  Math.Pow((y2 - y1), 2)
                                  );
            return distancia; 
        }
        private double CalcularBase()
        {
            double base1 = 0;
            base1 = CalcularDistancia(x1, y1, x2, y2);            
            return base1;
        }
        private double CalcularAltura()
        {
            double altura = CalcularDistancia(x2, y2, x3, y3);            
            return altura;
        }
        public double CalcularArea()
        {        
        return CalcularBase()*CalcularAltura();        
        }



    }
}
