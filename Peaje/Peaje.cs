using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peaje
{
    public class Peaje
    {
        public const float impuesto = 20.0f;
        public float recaudacion { get; set; }

        private List<Vehiculo> vehiculoLista = new List<Vehiculo>();

        
        
        private void RecibirVehiculo(Vehiculo vehiculo)
        {
        
                if (vehiculo is Ambulancia)
                {
                    if (((Ambulancia)vehiculo).emergencia)
                    {
                        vehiculoLista.Insert(0, vehiculo);
                        
                    }
                    else
                    {
                        vehiculoLista.Add(vehiculo);
                    }
                }
                else
                {
                    vehiculoLista.Add(vehiculo);
                }
                Console.WriteLine("Ha llegado un " + vehiculo.GetType().ToString());
        
        }

        private void CobrarVehiculo(Vehiculo vehiculo)
        {
                if (vehiculoLista.Count > 0)
                {
                    float importePagado = vehiculoLista[0].Pagar(impuesto);
                    vehiculoLista.RemoveAt(0);
                    Console.WriteLine("Un " + vehiculo.GetType().ToString() + " ha pagado " + importePagado.ToString());
                }
        
        }

        public void Iniciar()
        { 
            RecibirVehiculo( new Coche() {personas = 3});            
            RecibirVehiculo(new Coche() { personas = 2 });            
            RecibirVehiculo(new Camion() { peso = 3000 });
            RecibirVehiculo(new Camion() { peso = 12000 });
            RecibirVehiculo(new Coche() { personas = 5 });
            RecibirVehiculo(new Coche() { personas = 4 });
            RecibirVehiculo(new Camion() { peso = 2000 });            
            RecibirVehiculo(new Ambulancia() { emergencia = true });
            RecibirVehiculo(new Camion() { peso = 63000 });
            RecibirVehiculo(new Camion() { peso = 7000 }); 
            RecibirVehiculo(new Ambulancia() { emergencia = false });
            RecibirVehiculo(new Ambulancia() { emergencia = false });
            RecibirVehiculo(new Coche() { personas = 1 });
            RecibirVehiculo(new Ambulancia() { emergencia = true });

            for (int i = vehiculoLista.Count-1; i > 0; i--)                
            {
                Vehiculo vehiculo = vehiculoLista[0];
                CobrarVehiculo(vehiculo);                
            }
        }
    }
}
