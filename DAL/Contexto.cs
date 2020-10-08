using P1AP2_JohanLuis.Models;
using System;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace P1AP2_JohanLuis.DAL
{
    public class Contexto
    {
        public DbSet<Articulos> Articulos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source= Data\ArticulosDB.db");

        }

        internal object Entry(Articulos articulo)
        {
            throw new NotImplementedException();
        }
    }

}
