﻿using Parcial1_WalderReyes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parcial1_WalderReyes.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Inventario> Inventario { get; set; }

        public DbSet<Ubicacion> Ubicacion { get; set; }
        public Contexto() : base("DbParcial1-WalderReyes")
        {

        }
        
            
    }
}
