 public class ReporteAprobadas : IReporte
    {
        public void Ejecutar(Alumno[] alumnos)
        {
            Console.WriteLine("\n--- Notas Aprobadas ---");
            foreach (var alumno in alumnos)
            {
                Console.Write($"Alumno: {alumno.Nombre} - Aprobadas: ");
                bool tieneAprobadas = false;
                foreach (var nota in alumno.Notas)
                {
                    if (nota >= 65)
                    {
                        Console.Write(nota + " ");
                        tieneAprobadas = true;
                    }
                }
                if (!tieneAprobadas)
                    Console.Write("Ninguna");
                Console.WriteLine();
            }
        }
    }