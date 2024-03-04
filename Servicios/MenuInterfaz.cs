using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicacion
    /// irodhan -> 04/03/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra y selecciona la opcion deseada por el usuario del menu principal
        /// irodhan -> 04/03/2024
        /// </summary>
        /// <returns>Devuelve la opcion deseada por el usuario</returns>
        public int mostrarMenuYSeleccion();
        /// <summary>
        /// Metodo que muestra y selecciona la opcion deseada por el usuario del menu de la gerencia
        /// irodhan -> 04/03/2024
        /// </summary>
        /// <returns>Devuelve la opcion deseada por el usuario</returns>
        public int mostrarMenuYSeleccionGerencia();
        /// <summary>
        /// Metodo que muestra y selecciona la opcion deseada por el usuario del menu de los empleados
        /// irodhan -> 04/03/2024
        /// </summary>
        /// <returns>Devuelve la opcion deseada por el usuario</returns>
        public int mostrarMenuYSeleccionEmpleado();
    }
}
