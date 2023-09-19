namespace Ejercicio1;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número 1 Entero: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número 2 Entero: ");
        int numero2 = int.Parse(Console.ReadLine());

        int resultado = Multiplicar(numero1, numero2);

        Console.WriteLine($"El producto es: {resultado}");
    }

    static int Multiplicar(int numero1, int numero2)
    {
        int resultado = 0;

        for (int i = 0; i < Math.Abs(numero2); i++)
        { 
            if ((numero1 < 0 && numero2 > 0) || (numero1 > 0 && numero2 < 0))
            {
            resultado = -resultado;
            }

            resultado += numero1;
        }
        
        return resultado;
    }
}
