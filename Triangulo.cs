using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_S2
{
    internal class Triangulo : Figura
    {
        private float baseTriangulo;
        private float alturaTriangulo;

        public Triangulo(float baseTriangulo, float altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = altura;
        }

        public override float CalcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
        public override string ObtenerNombre()
        {
            return "Triángulo";
        }
    }
}
