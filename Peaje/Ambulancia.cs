using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peaje
{
    sealed class Ambulancia : Vehiculo
    {
        public bool emergencia { get; set; }
        public override float Pagar(float impuesto)
        {
            return 0f;
        }
    }
}
