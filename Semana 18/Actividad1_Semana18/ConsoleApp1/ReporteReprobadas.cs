public class ReporteReprobadas : IReporte
    {
        public void Ejecutar(Alumno[] alumnos)
        {
            Console.WriteLine("\n--- Notas Reprobadas ---");
            foreach (var alumno in alumnos)
            {
                Console.Write($"Alumno: {alumno.Nombre} - Reprobadas: ");
                bool tieneReprobadas = false;
                foreach (var nota in alumno.Notas)
                {
                    if (nota < 65)
                    {
                        Console.Write(nota + " ");
                        tieneReprobadas = true;
                    }
                }
                if (!tieneReprobadas)
                    Console.Write("Ninguna");
                Console.WriteLine();
            }
        }
    }