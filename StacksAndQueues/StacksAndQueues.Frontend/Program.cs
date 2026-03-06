using StacksAndQueus.Backend;
using System.ComponentModel.Design;
var stack = new StackUsingArray<string>(5);
var option = string.Empty;
do 
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.WriteLine("Ingrese el elemento a apilar:");
            var element = Console.ReadLine() ?? string.Empty;
            try
            {
                stack.Push(element);
                Console.WriteLine($"Elemento '{element}' apilado correctamente.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
            case "2":
            try
            {
                var poppedElement = stack.Pop();
                Console.WriteLine($"Elemento '{poppedElement}' desapilado correctamente.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
            case "3":
            try
            {
                var topElement = stack.Peek();
                Console.WriteLine($"El elemento en el tope es: '{topElement}'.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }

} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Apilar");
    Console.WriteLine("2. Desapilar");
    Console.WriteLine("3. Ver tope");
    Console.WriteLine("4. Salir");
    return Console.ReadLine() ?? string.Empty;
}
