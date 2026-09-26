using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_S2
{
    internal class Circulo : Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override float CalcularArea()
        {
            return radio * radio * 3.14f;
        }
        public override string ObtenerNombre()
        {
            return "Círculo";
        }
    }
}
