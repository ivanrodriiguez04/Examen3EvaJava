using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus
    /// irodhan -> 04/03/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            Console.WriteLine("     Menu     ");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Menu Empleados");
            Console.WriteLine("2. Menu Gerencia");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public int mostrarMenuYSeleccionEmpleado()
        {
            Console.WriteLine("     Menu     ");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Calculo de  ventas");
            Console.WriteLine("2. Añadir venta");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public int mostrarMenuYSeleccionGerencia()
        {
            Console.WriteLine("     Menu     ");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Guardar ventas en fichero");
            Console.WriteLine("2. Crear un nuevo pedido");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
