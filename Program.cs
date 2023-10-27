using ExamenDLL.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vendedores vendedores = new Vendedores();
            //vendedores.CalcularGanancia();

            //CURP curp = new CURP();
            //curp.Curp();

            Calificaciones calificaciones = new Calificaciones();
            calificaciones.OrdenSeleccion();

            Console.ReadKey();
        }
    }
}
