using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using AP2-P1.Models;


namespace AP2-P1.DAL
{

    public class Contexto : DbContext{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
        optionsBuilder.UseSqlite(@"Data Source= Data/Producto.db");
      }   
    }
}