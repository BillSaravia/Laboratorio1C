using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1C
{
    public  class automovil:vehiculo

    {

        public string combustible;

        public automovil(string MarcaA, string ModeloA, int AnnioA, string combustibleA)
                    : base(MarcaA, ModeloA, AnnioA)
        {
            combustible = combustibleA;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo de Capacidad:" + combustible);
        }

    }
}
