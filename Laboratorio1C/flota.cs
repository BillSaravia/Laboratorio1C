using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1C
{
    class Flota
    {
        private List<vehiculo> vehiculos { get; set; }

        public Flota()
        {
            vehiculos = new List<vehiculo>();
        }

        public void MostrarFlota()
        {
            foreach (vehiculo vehiculo in vehiculos)
            {
                vehiculo.MostrarInformacion();
            }
        }
    }
}