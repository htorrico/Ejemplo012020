﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public int Sumar(int a,int b)
        {
            return a + b;
        }
        public int SumarCoordenada()
        {
            return x1 + y1;
        }



    }
}
