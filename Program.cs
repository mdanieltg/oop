using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Tienes perros? (s/n): ");
            var key = Console.ReadKey();

            if (key.KeyChar != 's')
            {
                return;
            }

            Console.WriteLine();
            Console.Write("\n¿Cuántos perros tienes? ");
            int cantidad;
            int.TryParse(Console.ReadLine(), out cantidad);

            var perros = new Perro[cantidad];

            int n = 0;
            while (n < cantidad)
            {
                Console.Write($"\nNombre de tu perro ({n + 1}): ");  // Interpolación de texto
                var nombre = Console.ReadLine();
                Console.Write("Raza de tu perro ({0}): ", n + 1);    // Interpolación de texto
                var raza = Console.ReadLine();
                Console.Write($"Color de tu perro ({n + 1}): ");
                var color = Console.ReadLine();
                Console.Write($"Tamaño de tu perro ({n + 1}): ");
                var tamaño = Console.ReadLine();
                Console.Write("¿Tu perro ({0}) está vacunado? (s/n) ", n + 1);
                key = Console.ReadKey();
                bool vacunado = key.KeyChar == 's';

                var perro = new Perro(nombre, vacunado)
                {
                    Raza = raza,
                    Color = color,
                    Tamaño = tamaño
                };


                if (!perro.Vacunado)
                {
                    Vet.VacunarPerro(perro);
                }

                perros[n] = perro;

                Console.WriteLine();
                ++n;
            }

            foreach (var perro in perros)
            {
                Console.WriteLine();
                Console.WriteLine(perro.ImprimirDatos());
            }
        }
    }
}
