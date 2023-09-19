namespace Ejercicio3;

class Program
{
    static void Main(string[] args)
    { 
            Console.Write("Ingrese el número de notas: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("La cantidad de notas debe ser mayor que cero.");
                return;
            }

            double sumaNotas = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Ingrese la nota {i}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                sumaNotas += nota;
            }

            double promedio = sumaNotas / n;

            Console.WriteLine($"El promedio es: {promedio}");
    }
}

