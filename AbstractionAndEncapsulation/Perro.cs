using System;

namespace AbstractionAndEncapsulation
{
    public class Perro
    {
        private bool estabaVacunado;

        public Perro(string nombre, bool vacunado)
        {
            Nombre = nombre;
            Vacunado = vacunado;
            estabaVacunado = vacunado;
        }

        public string Nombre { get; private set; }

        public string Raza { get; set; }

        public string Tamaño { get; set; }

        public string Color { get; set; }

        public bool Vacunado { get; set; }

        public string ImprimirDatos()
        {
            string mensajeVacuna;

            mensajeVacuna = estabaVacunado
                ? "Ya está vacunado"
                : "No estaba vacunado, lo vacunamos por ti";

            // mensajeVacuna = estabaVacunado switch {
            //     true => "Ya está vacunado",
            //     false => "No estaba vacunado, lo vacunamos por ti"
            // };

            var texto = $"{Nombre} es un {Raza} {Color}, de tamaño {Tamaño}; {mensajeVacuna}."; // Interpolación de texto
            // var texto = string.Format("{0} es un {1} {2}, de tamaño {3}; {4}.", Nombre, Raza, Color, Tamaño, mensajeVacuna); // Lo que hace la interpolación de texto detrás de bambalinas

            return texto;
        }
    }
}
