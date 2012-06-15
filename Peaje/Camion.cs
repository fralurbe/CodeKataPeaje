using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peaje
{
    sealed class Camion : Vehiculo
    {
        public int peso { get; set; }
        public override float Pagar(float impuesto)
        {
            return peso * impuesto; ;            
        }
    }
}
