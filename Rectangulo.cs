using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_S2
{
    internal class Rectangulo : Figura
    {
        private float baseRectangulo;
        private float alturaRectangulo;

        public Rectangulo(float baseRectangulo, float altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = altura;
        }

        public override float CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }
        public override string ObtenerNombre()
        {
            return "Rectángulo";
        }

    }
}
