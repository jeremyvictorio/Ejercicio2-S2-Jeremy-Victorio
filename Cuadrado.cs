using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_S2
{
    internal class Cuadrado : Rectangulo
    {
        private float lado;

        public Cuadrado(float lado): base(lado, lado)
        {
            this.lado = lado;
        }

        public override float CalcularArea()
        {
            return lado * lado;
        }
        public override string ObtenerNombre()
        {
            return "Cuadrado";
        }
    }
}
