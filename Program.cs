
string? opcionElegida = string.Empty;

while (true)
{
    Console.WriteLine("Bienvenido a los ejemplos de Ideas Exponenciales.");
    Console.WriteLine("A continuación elige la opción que deseas utilizar:\n\n");
    Console.WriteLine("1) Comparación con double");
    Console.WriteLine("2) Comparación con decimal");
    Console.WriteLine("\nX) Salir\n\n");
    Console.Write("escribe tu elección y presiona <enter>: ");
    opcionElegida = (Console.ReadLine()??string.Empty).ToUpper();

    switch (opcionElegida)
    {
        case "1":
            break;
        case "2":
            break;
    }
    if(opcionElegida.Equals("X"))
    {
        break;
    }
}

