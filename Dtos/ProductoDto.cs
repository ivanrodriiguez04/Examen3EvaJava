using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irodhan.Dtos
{
    /// <summary>
    /// Clase que contiene los dtos de los productos
    /// irodhan -> 04/03/2024
    /// </summary>
    internal class ProductoDto
    {
        //Atributos
        long idProducto;
        string nombreProducto = "aaaaa";
        int cantidadProducto = 0;
        int eurosVenta = 0;
        DateTime instanteCompra;
        DateTime fechaEntrega;

        //Getters & Setters
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime InstanteCompra { get => instanteCompra; set => instanteCompra = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public int EurosVenta { get => eurosVenta; set => eurosVenta = value; }

        //Constructores
        public ProductoDto()
        {
        }
        public ProductoDto(long idProducto = 0, string nombreProducto = null, int cantidadProducto = 0, DateTime instanteCompra = default, DateTime fechaEntrega = default, int eurosVenta = 0)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.instanteCompra = instanteCompra;
            this.fechaEntrega = fechaEntrega;
            this.eurosVenta = eurosVenta;
        }

        //Metodos
        public string ToString() 
        {
            string concatenacion =
                "-----------------------------"
                +"\nProducto: "+this.nombreProducto
                +"\nCantidad: "+this.cantidadProducto
                +"\nFecha entrega: "+this.fechaEntrega.ToString("dd/MM/yyyy")
                +"\n-----------------------------";
            return concatenacion;
        }
    }
}
