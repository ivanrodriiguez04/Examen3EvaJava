using irodhan.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones de la aplicacion
    /// irodhan -> 04/03/2024
    /// </summary>
    internal class OperacionalImplementacion : OperacionalInterfaz
    {
        public void andairVenta(List<ProductoDto> listaProductosAntigua)
        {
            ProductoDto producto = new ProductoDto();

            producto.IdProducto = calculoId(listaProductosAntigua);
            Console.WriteLine("Cuanto ha sido el total de la venta:");
            producto.EurosVenta = Convert.ToInt32(Console.ReadLine());
            producto.InstanteCompra=DateTime.Now;
            listaProductosAntigua.Add(producto);
        }

        public void calculoVentas(List<ProductoDto> listaProductosAntigua)
        {
            Console.WriteLine("De que dia nececita hacer el calculo total(dd-MM-yyyy):");
            DateTime f1=Convert.ToDateTime(Console.ReadLine());
            if (listaProductosAntigua.Equals(f1)) 
            { 
                
            }
        }

        public string crearFichero(ProductoDto productos)
        {
            ProductoDto producto = new ProductoDto();

            string contenido =
                "----------------------------"
                +"Venta numero: "+producto.IdProducto
                +"Euros: "+producto.EurosVenta
                +"Instante compra: "+producto.InstanteCompra;

            return contenido;    
        }
       
        public void crearPedidoProveedores(List<ProductoDto> listaProductosAntigua)
        {
            ProductoDto pedido = new ProductoDto();
            string confirmacion;
            do
            {
                pedido.IdProducto = calculoId(listaProductosAntigua);
                Console.WriteLine("Que producto desea:");
                pedido.NombreProducto = Console.ReadLine();
                Console.WriteLine("Que cantidad de producto:");
                pedido.CantidadProducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Que dia desea la entrega:");
                pedido.FechaEntrega = Convert.ToDateTime(Console.ReadLine());
                listaProductosAntigua.Add(pedido);
                Console.WriteLine("Desea añadir otro pedido:");
                confirmacion=Console.ReadLine();
            } while (confirmacion.Equals("s"));
            listaProductosAntigua.Add(pedido);
            Console.WriteLine(pedido.ToString);
        }

        private int calculoId(List<ProductoDto> listaProductosAntigua) 
        { 
            int id = 0;
            for (int i = 0; i < listaProductosAntigua.Count; i++) 
            {
                id = i;
            }
            return id;
        }
    }
}
