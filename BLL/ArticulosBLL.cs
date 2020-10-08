using P1AP2_JohanLuis.DAL;
using P1AP2_JohanLuis.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace P1AP2_JohanLuis.BLL
{
    public class ArticulosBLL
    {
            public static bool Guardar(Articulos articulo)
            {

                if (!Existe(articulo.ArticuloId))
                    return Insertar(articulo);
                else
                    return Modificar(articulo);

            }

            private static bool Insertar(Articulos articulo)
            {

                bool paso = false;
                Contexto contexto = new Contexto();

                try
                {
                    contexto.Articulos.Add(articulo);
                    paso = contexto.SaveChanges() > 0;

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

            public static bool Modificar(Articulos articulo)
            {

                bool paso = false;
                Contexto contexto = new Contexto();

                try
                {

                    contexto.Entry(articulo).State = EntityState.Modified;
                    paso = contexto.SaveChanges() > 0;

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

            public static bool Eliminar(int id)
            {

                bool paso = false;
                Contexto contexto = new Contexto();
                try
                {

                    var articulo = contexto.Articulos.Find(id);

                    if (articulo != null)
                    {

                        contexto.Articulos.Remove(articulo);
                        paso = contexto.SaveChanges() > 0;
                    }

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

            public static Articulos Buscar(int id)
            {

                Contexto contexto = new Contexto();
                Articulos articulos;

                try
                {

                    articulos = contexto.Articulos.Find(id);

                }
                catch (Exception)
                {

                    throw;

                }
                finally
                {

                    contexto.Dispose();
                }

                return articulos;

            }

            public static List<Articulos> GetList(Expression<Func<Articulos, bool>> criterio)
            {


                List<Articulos> lista = new List<Articulos>();
                Contexto contexto = new Contexto();

                try
                {

                    lista = contexto.Articulos.Where(criterio).ToList();

                }
                catch (Exception)
                {

                    throw;

                }
                finally
                {

                    contexto.Dispose();

                }
                return lista;
            }

            public static bool Existe(int id)
            {

                Contexto contexto = new Contexto();
                bool encontrado = false;

                try
                {

                    encontrado = contexto.Articulos.Any(e => e.ArticuloId == id);

                }
                catch (Exception)
                {

                    throw;

                }
                finally
                {

                    contexto.Dispose();

                }
                return encontrado;
            }

            public static List<Articulos> GetCategorias()
            {

                List<Articulos> lista = new List<Articulos>();
                Contexto contexto = new Contexto();

                try
                {

                    lista = contexto.Articulos.ToList();

                }
                catch (Exception)
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

