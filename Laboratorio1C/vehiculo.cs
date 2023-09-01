using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio1C
{
    public class vehiculo
    {
        public string Marca {get ;set;}
        public string Modelo { get ;set;}
        public int Annio { get ;set;}

        public vehiculo(string marcaA, string modeloA, int annioA)
        {
            Marca = marcaA;
            Modelo = modeloA;
            Annio = annioA;

        }

        public virtual void MostrarInformacion() 
        {
            Console.WriteLine("Marca" + Marca + "Modelo" +Modelo+ "Año" +Annio);
        }

 
    }
}
