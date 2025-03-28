﻿using CapaDatos;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class CN_Compra
    {
        private CD_Compra objetoCD = new CD_Compra();

        public int InsertarCompra(int idEmpleado, int idProveedor, DateTime fechaCompra, decimal totalCompra, List<DetalleCompra> detalleCompras)
        {
            objetoCD.InsertarCompra(idEmpleado, idProveedor, fechaCompra, totalCompra);

            int idCompra = objetoCD.ObtenerUltimaCompraId();

            foreach (var detalle in detalleCompras)
            {
                objetoCD.InsertarDetalleCompra(idCompra, detalle.IdProducto, detalle.Cantidad, detalle.PrecioCompra);
            }

            return idCompra;
        }

        public List<Producto> ObtenerProductos()
        {
            return objetoCD.ObtenerProductos();
        }

        public List<Proveedor> ObtenerProveedores()
        {
            return objetoCD.ObtenerProveedores();
        }

        public void ActualizarStock(int idProducto, int cantidad)
        {
            objetoCD.ActualizarStock(idProducto, cantidad);
        }

        public List<Producto> ObtenerProductosPorProveedor(int idProveedor)
        {
            return objetoCD.ObtenerProductosPorProveedor(idProveedor);
        }
    }
}
