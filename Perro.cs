using System;

namespace POO
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
                ? "ya se encontraba vacunado."
                : "no estaba vacunado, lo vacunamos por ti.";

            // mensajeVacuna = estabaVacunado switch {
            //     true => "Ya se encuentra vacunado.",
            //     false => "Tu perro no estaba vacunado, ahora sí."
            // };

            var texto = string.Format("Tu perro se llama {0},\n  su raza es {1},\n  su color es {2},\n  su tamaño es {3},\n  {4}",
                Nombre, Raza, Color, Tamaño, mensajeVacuna);

            return texto;
        }
    }
}
