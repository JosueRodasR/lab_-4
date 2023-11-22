using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab__4
{
    public class Pantallas
    {
        public static int[] edades = new int[1000];
        public static bool[] vacunado = new bool[1000];
        public static int totalEncuestados = 0;
        public static int PantallaPrincipal()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Encuesta Covid-19");
            Console.WriteLine("=============================");
            Console.WriteLine("1: Realizar Encuesta");
            Console.WriteLine("2: Mostrar Datos de la encuesta");
            Console.WriteLine("3: Mostrar Resultados");
            Console.WriteLine("4: Buscar Personas por edad");
            Console.WriteLine("5: Salir");
            Console.WriteLine("===============================");
            Console.Write("Ingrese una opción: ");

        }
        public static int RealizarEncuesta()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Encuesta de vacunacion");
            Console.WriteLine("=================================");
            Console.Write("¿que edad tienes");
            int edad;
            while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0)
            {
                Console.WriteLine("Ingrese una edad válida.");
            }
            Console.WriteLine("Te has vacunado ");
            Console.WriteLine("1: Sí");
            Console.WriteLine("2: No");

            int opcionVacuna;
            do
            {
                Console.Write("Ingrese una opción: ");
            } while (!int.TryParse(Console.ReadLine(), out opcionVacuna) || (opcionVacuna != 1 && opcionVacuna != 2));

            edades[totalEncuestados] = edad;
            vacunado[totalEncuestados] = (opcionVacuna == 1);
            totalEncuestados++;

            Console.WriteLine("===========================");
            Console.WriteLine("¡Gracias por participar!");
            Console.WriteLine("===========================");
        }
        public static int MostrarDatosDeEncuestas()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Datos de la encuesta");
            Console.WriteLine("===================================");
            Console.WriteLine("ID | Edad | Vacunado");

            for (int i = 0; i < totalEncuestados; i++)
            {
                Console.WriteLine($"{i:D4} | {edades[i]} | {(vacunado[i] ? "Si" : "No")}");
            }

            Console.WriteLine("============================");
        }
        public static int MostrarResultados()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Resultados de la encuesta");
            Console.WriteLine("===============================");

            int vacunados = 0;
            int noVacunados = 0;
            int[] rangoEdades = new int[6];

            for (int i = 0; i < totalEncuestados; i++)
            {
                if (vacunado[i])
                {
                    vacunados++;
                }
                else
                {
                    noVacunados++;
                }

                if (edades[i] >= 1 && edades[i] <= 20)
                {
                    rangoEdades[0]++;
                }
                else if (edades[i] >= 21 && edades[i] <= 30)
                {
                    rangoEdades[1]++;
                }
                else if (edades[i] >= 31 && edades[i] <= 40)
                {
                    rangoEdades[2]++;
                }
                else if (edades[i] >= 41 && edades[i] <= 50)
                {
                    rangoEdades[3]++;
                }
                else if (edades[i] >= 51 && edades[i] <= 60)
                {
                    rangoEdades[4]++;
                }
                else
                {
                    rangoEdades[5]++;
                }
            }
            Console.WriteLine($"{vacunados} personas se han vacunado");
            Console.WriteLine($"{noVacunados} personas no se han vacunado");
            Console.WriteLine($"Existen:");
            for (int i = 0; i < rangoEdades.Length; i++)
            {
                Console.WriteLine($"{rangoEdades[i]:D2} personas entre {(i * 10 + 1)} y {(i + 1) * 10} años");
            }

            Console.WriteLine("===============================");
        }
        public static int BuscarPorEdad()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Busca a personas por edad");
            Console.WriteLine("===============================");

            Console.Write("¿Qué edad quieres buscar?: ");
            int edadBuscar;
            while (!int.TryParse(Console.ReadLine(), out edadBuscar) || edadBuscar <= 0)
            {
                Console.WriteLine("Ingrese una edad válida.");
            }

            int vacunados = 0;
            int noVacunados = 0;

            for (int i = 0; i < totalEncuestados; i++)
            {
                if (edades[i] == edadBuscar)
                {
                    if (vacunado[i])
                    {
                        vacunados++;
                    }
                    else
                    {
                        noVacunados++;
                    }
                }
            }

            Console.WriteLine($"{vacunados} se vacunaron");
            Console.WriteLine($"{noVacunados} no se vacunaron");
            Console.WriteLine("===============================");
        }
    }
}
    



