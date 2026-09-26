using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_S2
{
    internal class Menu
    {
        public void Execute()
        {
            List<Figura> figuras = new List<Figura>();

            int opcion = 0;

            while (opcion != 3)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Agregar figura");
                Console.WriteLine("2. Mostrar todas las figuras");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("¿Qué figura desea agregar?");
                        Console.WriteLine("1. Rectángulo");
                        Console.WriteLine("2. Cuadrado");
                        Console.WriteLine("3. Círculo");
                        Console.WriteLine("4. Triángulo");
                        Console.Write("Seleccione: ");

                        int tipo = int.Parse(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.Write("Base: ");
                                float baseRectangulo = float.Parse(Console.ReadLine());

                                Console.Write("Altura: ");
                                float alturaRectangulo = float.Parse(Console.ReadLine());

                                figuras.Add(new Rectangulo(baseRectangulo, alturaRectangulo));
                                break;

                            case 2:
                                Console.Write("Lado: ");
                                float lado = float.Parse(Console.ReadLine());

                                figuras.Add(new Cuadrado(lado));
                                break;

                            case 3:
                                Console.Write("Radio: ");
                                float radio = float.Parse(Console.ReadLine());

                                figuras.Add(new Circulo(radio));
                                break;

                            case 4:
                                Console.Write("Base: ");
                                float baseTriangulo = float.Parse(Console.ReadLine());

                                Console.Write("Altura: ");
                                float alturaTriangulo = float.Parse(Console.ReadLine());

                                figuras.Add( new Triangulo(baseTriangulo, alturaTriangulo));
                                break;

                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                        }

                        break;

                    case 2:
                        Console.WriteLine("FIGURAS:");
                        foreach (Figura figura in figuras)
                        {
                            Console.WriteLine($"Area del {figura.ObtenerNombre()}:" + figura.CalcularArea());
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;

                }
            }
        
        }
    }
}
