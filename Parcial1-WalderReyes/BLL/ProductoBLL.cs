﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_WalderReyes.Entidades;
using Parcial1_WalderReyes.DAL;
using System.Linq.Expressions;

namespace Parcial1_WalderReyes.BLL
{
    public class ProductoBLL
    {
       
        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos productos = new Productos();
            try
            {
                productos = contexto.Productos.Find(id);
            }
            catch
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return productos;
        }


        public static Inventario LlenaClase()
        {
            Inventario inventario = new Inventario();
            inventario.Total = 0;
            inventario.IdInventario = 1;

            return inventario;
        }
        public static bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Inventario inventario = new Inventario();
            try
            {
                inventario = InventarioBLL.Buscar(1);
                if (inventario == null)
                {

                    inventario = LlenaClase();
                    paso = InventarioBLL.Guardar(inventario);

                }



                if (contexto.Productos.Add(productos) != null)
                    paso = contexto.SaveChanges() > 0;

                inventario.Total += productos.ValorInventario;
                InventarioBLL.Modificar(inventario);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var buscar = contexto.Productos.Find(productos.ProductoId);
                contexto.Entry(productos).State = System.Data.Entity.EntityState.Modified;
                paso = (contexto.SaveChanges()>0);

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
             var eliminar = contexto.Productos.Find(id);

                var Inventario = InventarioBLL.Buscar(1);
                Inventario.Total -= eliminar.ValorInventario;
                InventarioBLL.Modificar(Inventario);

                contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static List<Productos> GetList(Expression<Func<Productos,bool>>productos)
        {
            Contexto contexto = new Contexto();
            List<Productos> lista = new List<Productos>();
            try
            {
                lista = contexto.Productos.Where(productos).ToList();

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }

    
}
