using EjemplosCodigo.Business;


string? opcionElegida = string.Empty;

while (true)
{
    Console.Clear();
    Console.WriteLine("Bienvenido a los ejemplos de Ideas Exponenciales.");
    Console.WriteLine("A continuación elige la opción que deseas utilizar:\n\n");
    Console.WriteLine("1) Comparación con double");
    Console.WriteLine("2) Comparación con decimal");
    Console.WriteLine("3) Ejemplo con Dynamic");
    Console.WriteLine("\nX) Salir\n\n");
    Console.Write("escribe tu elección y presiona <enter>: ");
    opcionElegida = (Console.ReadLine()??string.Empty).ToUpper();

    DoubleComparator comparadorDobles = new DoubleComparator();
    DecimalComparator comparadorDecimal = new DecimalComparator();
    DynamicExample dynamicEjemplo = new DynamicExample();
    switch (opcionElegida)
    {
        case "1":
            comparadorDobles.ComparaValores();
            break;
        case "2":
            comparadorDecimal.ComparaValores();
            break;
        case "3":
            dynamicEjemplo.EjemploVariableDinamica();
            break;
    }
    if(opcionElegida.Equals("X"))
    {
        break;
    }
}

