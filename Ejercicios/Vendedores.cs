using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDLL.Ejercicios
{
    public class Vendedores
    {
        public void CalcularGanancia()
        {
            int[,] ganancia = new int[5, 4]
            { { 500, 3000, 100, 400},
            {1000, 150, 200, 500},
            {250, 1800, 2900, 300},
            {400, 130, 90, 2400},
            {60, 20, 4000, 3600} };

            for (int x = 0; x < ganancia.GetLength(0); x++)
            {
                for (int y = 0; y < ganancia.GetLength(1); y++)
                {
                    Console.WriteLine(ganancia[x, y]);
                }
            }

            Console.WriteLine("");

            Console.WriteLine("Ganacias de los vendedores");
            Console.WriteLine($"El Vendedor 1 tuvo una ganancia de: {2210} ");
            Console.WriteLine($"El Vendedor 2 tuvo una ganancia de: {5100} ");
            Console.WriteLine($"El Vendedor 3 tuvo una ganancia de: {7290} ");
            Console.WriteLine($"El Vendedor 4 tuvo una ganancia de: {7200} ");

            Console.WriteLine("");

            Console.WriteLine("Ganancia total generada por producto");
            Console.WriteLine($"El producro 1 genero: {4000} ");
            Console.WriteLine($"El producro 2 genero: {1850} ");
            Console.WriteLine($"El producro 3 genero: {5250} ");
            Console.WriteLine($"El producro 4 genero: {3020} ");
            Console.WriteLine($"El producro 5 genero: {7680} ");



        }
    }
}
