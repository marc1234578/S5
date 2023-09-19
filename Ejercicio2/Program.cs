namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la base: ");
        double baseNumero = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el exponente: ");
        int exponente = Convert.ToInt32(Console.ReadLine());

        double resultado = 1; 
        
        for (int i = 0; i < exponente; i++)
        {
            resultado *= baseNumero;
        }

        Console.WriteLine($"La potencia es:" +resultado);
        Console.ReadKey();
    }
}



        
    

