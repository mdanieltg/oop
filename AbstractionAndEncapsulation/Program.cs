using System;

namespace AbstractionAndEncapsulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("¿Tienes perros? (s/n): ");
            var key = Console.ReadKey();

            if (key.KeyChar != 's')
            {
                return;
            }

            Console.WriteLine();
            Console.Write("¿Cuántos perros tienes? ");
            //int cantidad;
            int.TryParse(Console.ReadLine(), out int cantidad);

            var perros = new Perro[cantidad];

            int n = 0;
            while (n < cantidad)
            {
                Console.WriteLine("\nDatos del perro #{0}.", n + 1);
                
                Console.Write(" Nombre del perro: ");
                var nombre = ValidadorDeEntrada.Leer(true);

                Console.Write(" Raza de {0}: ", nombre);
                var raza = ValidadorDeEntrada.Leer(true);

                Console.Write(" Color de {0}: ", nombre);   
                var color = ValidadorDeEntrada.Leer().ToLower();

                Console.Write(" Tamaño de {0}: ", nombre);
                var tamaño = ValidadorDeEntrada.Leer();

                Console.Write(" ¿Está {0} vacunado? (s/n): ", nombre);
                var vacunado = Console.ReadKey().KeyChar == 's';

                Console.WriteLine();

                var perro = new Perro(nombre, vacunado)
                {
                    Raza = raza,
                    Color = color,
                    Tamaño = tamaño
                };

                perros[n] = perro;

                ++n;
            }

            Console.WriteLine();
            foreach (var perro in perros)
            {
                if (!perro.Vacunado)
                {
                    Vet.VacunarPerro(perro);
                }

                Console.WriteLine(perro.ImprimirDatos());
            }
        }
    }
}
