﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones Objeto = new Operaciones();//Instancio objeto de la clase Operaciones
            Objeto.LlamarHanoi();//Llamo metodo de la clase Operaciones
        }
    }
}
