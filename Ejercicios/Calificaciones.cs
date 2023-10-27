using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDLL.Ejercicios
{
    public class Calificaciones
    {
        public void OrdenSeleccion() 
        {
            int[] calificacion = new int[100];
            Random random = new Random();

            Console.WriteLine("Lista Desordenada:");
            Console.WriteLine("");

            for (int x = 0; x < calificacion.Length; x++) 
            {
                calificacion[x] = random.Next();
                Console.WriteLine(calificacion[x]);
            }

            int menor = 0;
            int pos = 0;
            int temp = 0;

            for (int i = 0; i < calificacion.Length - 1; i++)
            {
                menor = calificacion[i];
                pos = i;
                for (int j = i + 1; j < calificacion.Length; j++)
                {
                    if (calificacion[j] < menor)
                    {
                        menor = calificacion[j];
                        pos = j;
                    }

                }
                if (pos != i)
                {
                    temp = calificacion[i];
                    calificacion[i] = calificacion[pos];
                    calificacion[pos] = temp;
                }
            }

            Console.WriteLine("");

            Console.WriteLine("Lista Ordenada:");
            Console.WriteLine("");
            for (int i = 0; i < calificacion.Length; i++)
            {
                Console.WriteLine(calificacion[i]);
            }

            int numeroBuscar = 75;

            int inicio = 0;
            int fin = calificacion.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (calificacion[medio] == numeroBuscar)
                {
                    posicion = medio;
                    break;
                }
                else if (calificacion[medio] < numeroBuscar)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            Console.WriteLine(""); 

            if (posicion != -1)
            {
                Console.WriteLine($"El numero {numeroBuscar} se encuentra en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine($"El numero {numeroBuscar} no se encuentra.");
            }
        }
    }
}
