using System.Runtime.CompilerServices;
using System;

namespace EjemplosCodigo.Business
{
    public class DecimalComparator
    {
        private decimal variableDecimal1 = 0.1M;
        private decimal variableDecimal2 = 0.2M;
        private decimal resultadoDecimalEsperado = 0.3M;

        public void ComparaValores()
        {
            Console.Clear();
            Console.WriteLine("Comparando valores de variables del tipo 'Decimal'.\n");
            Console.WriteLine("Comparación directa con 0.3");
            if ( variableDecimal1 + variableDecimal2 == 0.3M)
            {
                Console.WriteLine($"{variableDecimal1} + {variableDecimal2} es IGUAL a 0.3 ");
            }
            else
            {
                Console.WriteLine($"{variableDecimal1} + {variableDecimal2} es DIFERENTE a 0.3 ");
            }

            Console.WriteLine("\nComparación directa contra otra variable Decimal");
            if (variableDecimal1 + variableDecimal2 == resultadoDecimalEsperado)
            {
                Console.WriteLine($"{variableDecimal1} + {variableDecimal2} es IGUAL a {resultadoDecimalEsperado}");
            }
            else
            {
                Console.WriteLine($"{variableDecimal1} + {variableDecimal2} es DIFERENTE a {resultadoDecimalEsperado} ");
            }

            Console.WriteLine("\n\nPresione cualquier tecla para regresar al menu inicial.");
            Console.ReadKey();
        }
    }
}