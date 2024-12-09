using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Simulador2DElectro1._0
{
    internal class Carga
    {
        public Vector2 Posicion { get; set; }
        public float Magnitud { get; set; }

        public Carga(Vector2 posicion, float magnitud)
        {
            Posicion = posicion;
            Magnitud = magnitud;
        }
    }
}
