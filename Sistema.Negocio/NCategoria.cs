﻿using Sistema.Datos;
using Sistema.Entidades;
using System.Data;

namespace Sistema.Negocio
{
    public class NCategoria
    {
        public static DataTable Listar()
        {
            DCategoria Datos = new DCategoria();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Buscar(Valor);
        }

        public static string Insertar(string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                Categoria Obj = new Categoria();
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int Id, string Nombre, string Descripcion)
        {
            DCategoria Datos = new DCategoria();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La categoría ya existe";
            }
            else
            {
                Categoria Obj = new Categoria();
                Obj.IdCategoria = Id;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
        }

        public static string Eliminar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DCategoria Datos = new DCategoria();
            return Datos.Desactivar(Id);
        }
    }
}
