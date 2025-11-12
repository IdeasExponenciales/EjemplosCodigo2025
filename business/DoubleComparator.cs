using System.Runtime.CompilerServices;
using System;

namespace EjemplosCodigo.Business
{
    public class DoubleComparator
    {
        private double variableDouble1 = 0.1;
        private double variableDouble2 = 0.2;
        private double resultadoEsperado = 0.3;

        public void ComparaValores()
        {
            Console.Clear();
            Console.WriteLine("Comparando valores de variables del tipo 'Double'.\n");
            Console.WriteLine("Comparación directa con 0.3");
            if (variableDouble1 + variableDouble2 == 0.3)
            {
                Console.WriteLine($"{variableDouble1} + {variableDouble2} es IGUAL a 0.3 ");
            }
            else
            {
                Console.WriteLine($"{variableDouble1} + {variableDouble2} es DIFERENTE a 0.3 ");
            }

            Console.WriteLine("\nComparación directa contra otra variable Double");
            if (variableDouble1 + variableDouble2 == resultadoEsperado)
            {
                Console.WriteLine($"{variableDouble1} + {variableDouble2} es IGUAL a {resultadoEsperado}");
            }
            else
            {
                Console.WriteLine($"{variableDouble1} + {variableDouble2} es DIFERENTE a {resultadoEsperado} ");
            }

            Console.WriteLine("\n\nPresione cualquier tecla para regresar al menu inicial.");
            Console.ReadKey();
        }
    }
}