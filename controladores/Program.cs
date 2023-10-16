//Alumno: Ruben Bernal Ramos
//Clase: CSI1

using edu.Ejercicio3_Prog.servicios;

namespace edu.Ejercicio3_Prog.controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 161023
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// rbr - 161023
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Instancio la interfaz y la implementacion
            MenuInterfaz mi = new MenuImplementacion();

            //Declaro las variables
            bool cerrarMenu = false;
            int opcion;

            while (!cerrarMenu)
            {
                //Muestro el menú por consola
                opcion = mi.mostrarMenu();
                switch (opcion)
                {
                    case 1:
                        cerrarMenu = true;
                        break;
                    case 2:
                        mi.igualdad();
                        break;
                    case 3:
                        mi.desigualdad();
                        break;
                    default:
                        Console.WriteLine("No has seleccionado una opcion correcta");
                        break;
                }
            }
        }
    }
}