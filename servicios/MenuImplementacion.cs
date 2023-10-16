//Alumno: Ruben Bernal Ramos
//Clase: CSI1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Ejercicio3_Prog.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método que mostrará el menú por consola
        /// rbr - 161023
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu()
        {
            int opcion;
            Console.WriteLine("###########################");
            Console.WriteLine("           MENU            ");
            Console.WriteLine("###########################");
            Console.WriteLine("1. Cerrar");
            Console.WriteLine("2. Igualdad");
            Console.WriteLine("3. Desigualdad");
            Console.WriteLine("###########################");
            Console.WriteLine("                           ");
            Console.WriteLine("Seleccione la opción que desee");

            opcion = Console.ReadKey(true).KeyChar - '0';
            return opcion;
        }

        /// <summary>
        /// Método para realizar la opción de igualdad entre dos variables
        /// rbr - 161023
        /// </summary>
        public void igualdad()
        {
            string exp1, exp2;
            bool resultado;
            Console.WriteLine("Has seleccionado la opción de igualdad");
            Console.WriteLine("Introduzca la primera expresión: ");
            exp1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca la segunda expresión: ");
            exp2 = Convert.ToString(Console.ReadLine());
            if(exp1 == exp2)
            {
                resultado = true;
                Console.WriteLine("El resultado de la igualdad es: " + resultado);
            }
            else
            {
                resultado = false;
                Console.WriteLine("El resultado de la igualdad es: " + resultado);
            }
        }

        /// <summary>
        /// Método para realizar la opción de desigualdad entre dos variables
        /// rbr - 161023
        /// </summary>
        public void desigualdad()
        {
            string exp1, exp2;
            bool resultado;
            Console.WriteLine("Has seleccionado la opción de desigualdad");
            Console.WriteLine("Introduzca la primera expresión: ");
            exp1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Introduzca la segunda expresión: ");
            exp2 = Convert.ToString(Console.ReadLine());
            if (exp1 != exp2)
            {
                resultado = true;
                Console.WriteLine("El resultado de la desigualdad es: " + resultado);
            }
            else
            {
                resultado = false;
                Console.WriteLine("El resultado de la desigualdad es: " + resultado);
            }
        }
    }
}
