using _2013204637;
using _2013204637_PER.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER
{
    class _2013204637_SLNDbContext : DbContext
    {
        public DbSet<ATM> ATMs { get; set; }
        public DbSet<BaseDatos> BaseDatos_s { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<DispensadorEfectivo> DispensadorEfectivo_s { get; set; }
        public DbSet<Pantalla> Pantallas { get; set; }
        public DbSet<RanuraDeposito> RanuraDeposito_s { get; set; }
        public DbSet<Retiro> Retiros { get; set; }
        public DbSet<Teclado> Teclados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ATMConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        
    }
}
