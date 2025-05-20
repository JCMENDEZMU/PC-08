public class ReportePromedioGrupo : IReporte
    {
        public void Ejecutar(Alumno[] alumnos)
        {
            int sumaTotal = 0;
            int totalNotas = 0;

            foreach (var alumno in alumnos)
            {
                foreach (var nota in alumno.Notas)
                {
                    sumaTotal += nota;
                    totalNotas++;
                }
            }

            double promedioGrupo = (double)sumaTotal / totalNotas;
            Console.WriteLine($"\nPromedio general del grupo: {promedioGrupo:F2}");
        }
    }