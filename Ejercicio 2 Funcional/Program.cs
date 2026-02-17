using System;

class Program
{
    // VARIABLES GLOBALES (estado global)
    static int pisoActual = 1;
    static int pisoDestino = 5;
    static Random r = new Random();

    static void Main()
    {
        Console.WriteLine("Inicio - Piso actual: " + pisoActual);
        Console.WriteLine("Destino inicial: " + pisoDestino);
        Console.WriteLine();

        for (int i = 0; i < 20; i++)
        {
            CambiarDestino(); // función con efecto secundario

            if (pisoActual < pisoDestino)
                pisoActual++;
            else if (pisoActual > pisoDestino)
                pisoActual--;

            Console.WriteLine("Piso actual: " + pisoActual + " | Destino: " + pisoDestino);
        }

        Console.WriteLine("\nFin de simulación");
    }

    // FUNCIÓN INESTABLE
    static void CambiarDestino()
    {
        // Probabilidad aleatoria de cambiar destino
        if (r.Next(4) == 0)
        {
            pisoDestino = r.Next(1, 11);
            Console.WriteLine("⚠ El destino cambió inesperadamente!");
        }
    }
}
