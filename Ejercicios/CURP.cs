using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDLL.Ejercicios
{
    public class CURP
    {
        public void Curp() 
        {
            string[] curp = new string[18];

            Console.WriteLine("Ingrese su CURP");

            for (int x = 0; x < curp.Length; x++) 
            {
                Console.WriteLine($"Ingrese el Caracter {x + 1}: ");
                curp[x] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("");
            
            if (curp[10] == "H") 
            {
                Console.WriteLine("Usted es de sexo Masculino");
            }

            else if (curp[10] == "M")
            {
                Console.WriteLine("Usted es de sexo Femenino");
            }

            else 
            {
                Console.WriteLine("No existes");
            }
            

            Console.ReadKey();
        }



        
    }
}
