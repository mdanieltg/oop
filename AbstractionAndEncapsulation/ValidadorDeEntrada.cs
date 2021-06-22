using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractionAndEncapsulation
{
    public static class ValidadorDeEntrada
    {
        public static string Leer(bool capitalizar = false)
        {
            string entrada;

            while (true)
            {
                entrada = Console.ReadLine().Trim();
                if (Regex.IsMatch(entrada, @"^[A-ZÁÉÍÓÚÑa-záéíóúñ]+( +[A-ZÁÉÍÓÚÑa-záéíóúñ]+)*$"))
                {
                    entrada = Regex.Replace(entrada, @" +", " ").ToLower();
                    if(capitalizar)
                    {
                        return Capitalize(entrada);
                    }
                    else
                    {
                        return entrada;
                    }
                }

                Console.Write("Entrada no válida, por favor intenta de nuevo: ");
            }
        }

        private static string Capitalize(string input)
        {
            var palabras = input.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                var caracteres = palabras[i].ToCharArray();
                caracteres[0] = char.ToUpper(caracteres[0]);
                palabras[i] = new string(caracteres);
            }

            return string.Join(' ', palabras);
        }
    }
}
