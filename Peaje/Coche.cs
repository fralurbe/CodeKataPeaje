using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peaje
{
    sealed class Coche : Vehiculo
    {
        public int personas { get; set; }
        public override float Pagar(float impuesto)
        {
            return personas * impuesto;
        }
    }
}
