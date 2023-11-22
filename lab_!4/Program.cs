using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.PantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.RealizarEncuesta();
                        break;
                    case 2:
                        opcion = Pantallas.MostrarDatosDeEncuestas();
                        break;
                    case 3:
                        opcion = Pantallas.MostrarResultados();
                        break;
                    case 4:
                        opcion = Pantallas.BuscarPorEdad();
                        break;
                    case 5:
                        Console.WriteLine("saliendo delprograma");
                        break;
                }
            }
            while( opcion != 5 );
            Console.ReadKey();
        }
    }
}
