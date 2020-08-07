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
    class Rectangulo2
    {

        //Propiedades de Navegaciòn
        public Punto punto1 { get; set; }
        public Punto punto2 { get; set; }
        public Punto punto3 { get; set; }
        public Punto punto4 { get; set; }


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
            base1 = CalcularDistancia(punto1.x, punto1.y, punto2.x, punto2.y);            
            return base1;
        }
        private double CalcularAltura()
        {
            double altura = CalcularDistancia(punto2.x, punto2.y, punto3.x, punto3.y);            
            return altura;
        }
        public double CalcularArea()
        {        
        return CalcularBase()*CalcularAltura();        
        }



    }
}
