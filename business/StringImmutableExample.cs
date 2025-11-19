using System.Runtime.CompilerServices;
using System;

namespace EjemplosCodigo.Business
{
    public class StringImmutableExample
    {
        public void EjemploInmutabilidad()
        {
            string cadena1 = string.Empty;
            string cadena2 = string.Empty;

            Console.Clear();
            Console.WriteLine("Ejemplo del uso de cadenas inmutales.\n\n");
            Console.WriteLine("Asignando valores.");
            Console.WriteLine("Asignando valor a cadena1.");
            cadena1 = "Hola, este es un ejemplo de uso de cadenas " + "desde cadena 1.";
            Console.WriteLine("Asignando valor a cadena2.");
            cadena2 = "Hola, este es un ejemplo de uso de cadenas " + "desde cadena 2.";
            Console.WriteLine("\n");
            Console.WriteLine("Revisando valores ");
            Console.WriteLine($"Valor de cadena1 = {cadena1}");
            Console.WriteLine($"Valor de cadena2 = {cadena2}");
            Console.WriteLine("\n\n");
            Console.WriteLine("Nueva asignación de valores ");
            Console.WriteLine("Asignando cadena2 = cadena1.");
            cadena2 = cadena1;
            Console.WriteLine("Concatenando valor inicial a cadena1.");
            cadena1.Concat(" - Valor contatenado a cadena 1");
            Console.WriteLine("\n");
            Console.WriteLine("Nueva revisión de valores ");
            Console.WriteLine($"Nuevo valor de cadena1 = {cadena1}");
            Console.WriteLine($"Nuevo valor de cadena2 = {cadena2}");
            Console.WriteLine("\n\n\nPresione cualquier tecla para regresar al menu inicial.");
            Console.ReadKey();
        }
    }
}