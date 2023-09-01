using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1C
{
    public class Camion:vehiculo
    {

        public double CapacidadCarga;

        public Camion(string MarcaA, string ModeloA, int AnnioA, double CapacidadCargaA)
                    : base(MarcaA, ModeloA, AnnioA)
        {
            CapacidadCarga = CapacidadCargaA;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo de Capacidad:" + CapacidadCarga);
        }

    }
}
