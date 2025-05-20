public class Alumno
    {
        public string Nombre;
        public int[] Notas;

        public Alumno(string nombre)
        {
            Nombre = nombre;
            Notas = new int[10];
        }

        public double CalcularPromedio()
        {
            int suma = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                suma += Notas[i];
            }
            return (double)suma / Notas.Length;
        }
    }

