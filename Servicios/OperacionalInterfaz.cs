using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Interfaz de las operaciones de la aplicacion
    /// irodhan -> 04/03/2024
    /// </summary>
    internal interface OperacionalInterfaz
    {
        /// <summary>
        /// Metodo que calcula las ventas del dia
        /// irodhan -> 04/03/2024
        /// </summary>
        public void calculoVentas(List<ProductoDto> listaProductosAntigua);
        /// <summary>
        /// Metodo que añade las ventas de los empleados
        /// irodhan -> 04/03/2024
        /// </summary>
        public void andairVenta(List<ProductoDto> listaProductosAntigua);
        /// <summary>
        /// Metodo que crea un pedido a los proveedores de los productos
        /// irodhan ->
        /// </summary>
        public void crearPedidoProveedores(List<ProductoDto> listaProductosAntigua);
        /// <summary>
        /// metodo que crea el fichero con la informacion deseada
        /// irodhan -> 04/03/2024
        /// </summary>
        public string crearFichero(ProductoDto producto);
    }
}
