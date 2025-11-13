
public class DynamicExample
{
    public void EjemploVariableDinamica()
    {
        dynamic variableDinamica;

        Console.WriteLine("Iniciando ejemplo con una variable del tipo dynamic.\n\n");

        //asignando un valor entero
        variableDinamica = 5;
        Console.WriteLine($"VariableDinamica contiene el valor: {variableDinamica}");
        Console.WriteLine($"VariableDinamica del tipo  : {variableDinamica.GetType()}");
        
        //asignando una cadena
        variableDinamica = "aquí se guarda una cadena";
        Console.WriteLine($"VariableDinamica contiene el valor: {variableDinamica}");
        Console.WriteLine($"VariableDinamica del tipo  : {variableDinamica.GetType()}");

        //asignando un arreglo numérico
        variableDinamica = new[] { 15, 10, 8 };

        Console.WriteLine($"VariableDinamica contiene el valor: {variableDinamica}");
        Console.WriteLine($"VariableDinamica del tipo  : {variableDinamica.GetType()}");

        Console.WriteLine("\n\nEjemplo completado");
        Console.WriteLine("Presina cualquier tecla para continuar... ");
        Console.ReadKey();
    }
}