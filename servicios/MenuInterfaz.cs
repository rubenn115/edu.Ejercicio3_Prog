﻿//Alumno: Ruben Bernal Ramos
//Clase: CSI1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Ejercicio3_Prog.servicios
{
    /// <summary>
    /// Esta es la interfaz donde estarán los métodos enunciados
    /// rbr - 161023
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Llamada al método que mostrará el menú por consola
        /// rbr - 161023
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();

        /// <summary>
        /// Llamada al método que verificará la igualdad entre dos expresiones
        /// rbr - 161023
        /// </summary>
        public void igualdad();

        /// <summary>
        /// Llamada al método que verificará la desigualdad entre dos expresiones
        /// rbr - 161023
        /// </summary>
        public void desigualdad();
    }
}
