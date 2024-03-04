using irodhan.Dtos;
using irodhan.Servicios;

namespace irodhan 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 04/03/2024
    /// </summary>
    class Program 
    {
        static string rutaFichero ="C:\\Users\\Trabajo\\Desktop\\";
        static List<ProductoDto> listaProductos = new List<ProductoDto>();
        /// <summary>
        /// Metodo principal de la aplicacion
        /// irodhan -> 04/03/2024
        /// </summary>
        static void Main(string[] args) 
        {
            ProductoDto productoDto = new ProductoDto();
            MenuInterfaz mI = new MenuImplementacion();
            OperacionalInterfaz oI = new OperacionalImplementacion();
            //Atributos
            int opcionSeleccionada = 0;
            bool cerrarMenu= false;
            
            while (!cerrarMenu) 
            {
                opcionSeleccionada = mI.mostrarMenuYSeleccion();
                switch (opcionSeleccionada) 
                { 
                    case 0:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                        Console.WriteLine("La aplicacion se va a cerrar");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                        opcionSeleccionada=mI.mostrarMenuYSeleccionEmpleado();
                        switch (opcionSeleccionada) 
                        {
                            case 0:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                                Console.WriteLine("[INFO] - Se va a volver al menu principal");
                                break;
                            case 1:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                                oI.calculoVentas(listaProductos);
                                break;
                            case 2:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion 2");
                                oI.andairVenta(listaProductos);
                                break;
                            default:
                                Console.WriteLine("[INFO] - La opcion seleccioanda no coincide con ninguna opcion mostrada anteiormente");
                                break;
                        }
                        break; 
                    case 2:
                        Console.WriteLine("[INFO] - Ha seleccionado la opcion 2");
                        opcionSeleccionada=mI.mostrarMenuYSeleccionGerencia();
                        switch (opcionSeleccionada)
                        {
                            case 0:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion 0");
                                Console.WriteLine("[INFO] - Se va a volver al menu principal");
                                break;
                            case 1:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion 1");
                                
                                foreach (ProductoDto producto in listaProductos)
                                {
                                    string nombreFichero =  producto.InstanteCompra.ToString("dd/MM/yyyy")+ ".txt";
                                    string rutaCompletaFichero = rutaFichero + nombreFichero;

                                    using (StreamWriter fichero = new StreamWriter(rutaCompletaFichero))
                                    {
                                        fichero.Write(oI.crearFichero(producto));
                                    };
                                }

                                break;
                            case 2:
                                Console.WriteLine("[INFO] - Ha seleccionado la opcion 2");
                                oI.crearPedidoProveedores(listaProductos);
                                break;
                            default:
                                Console.WriteLine("[INFO] - La opcion seleccioanda no coincide con ninguna opcion mostrada anteiormente");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente");
                        break;
                }
            }
        
        }
    }
}
