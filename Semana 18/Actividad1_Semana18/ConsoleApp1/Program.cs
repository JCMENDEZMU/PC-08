using System;

class Program
    {
        static void Main(string[] args)
        {
            // Crear los alumnos y registrar sus notas
            Alumno[] alumnos = new Alumno[10];

            Console.WriteLine("=== Registro de Alumnos ===");
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.Write($"Ingrese el nombre del alumno {i + 1}: ");
                string nombre = Console.ReadLine();
                alumnos[i] = new Alumno(nombre);

                for (int j = 0; j < 10; j++)
                {
                    alumnos[i].Notas[j] = PedirNotaValida($"Ingrese la nota {j + 1} para {nombre}: ");
                }
            }

            while (true)
            {
                Console.WriteLine("\n=== MENÚ DE REPORTES ===");
                Console.WriteLine("1 - Mostrar notas aprobadas");
                Console.WriteLine("2 - Mostrar notas reprobadas");
                Console.WriteLine("3 - Mostrar promedio del grupo");
                Console.WriteLine("4 - Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                IReporte reporte = null;

                switch (opcion)
                {
                    case "1":
                        reporte = new ReporteAprobadas();
                        break;
                    case "2":
                        reporte = new ReporteReprobadas();
                        break;
                    case "3":
                        reporte = new ReportePromedioGrupo();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        continue;
                }
                reporte.Ejecutar(alumnos);
            }
        }

        static int PedirNotaValida(string mensaje)
        {
            int nota;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out nota) && nota >= 0 && nota <= 100)
                {
                    return nota;
                }

                Console.WriteLine("Error: Ingrese un número entre 0 y 100.");
            }
        }
    }
