using System;

class Program
{
    static void Main()
    {
        Random r = new Random();

        int pisoActual = 1;
        int pisoDestino = r.Next(1, 11); 

        Console.WriteLine("El elevador esta en el piso: " + pisoActual);
        Console.WriteLine("Destino aleatorio: " + pisoDestino);
        Console.WriteLine();

        while (pisoActual != pisoDestino)
        {
            if (pisoActual < pisoDestino)
            {
                pisoActual++;
                Console.WriteLine("Piso: " + pisoActual + "  Direccion: Subiendo");
            }
            else
            {
                pisoActual--;
                Console.WriteLine("Piso: " + pisoActual + "  Direccion: Bajando");
            }
        }

        Console.WriteLine("\nEl elevador llego al piso destino.");
    }
}
