using _2013204637;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.EntitiesConfigurations
{
    public class RetiroConfiguration : EntityTypeConfiguration<Retiro>
    {
        public RetiroConfiguration()
        {
            HasKey(a => a.RetiroId);
            HasRequired(c => c.Teclado)
                .WithOptional(c => c.Retiro);
            HasOptional(c => c.DispensadorEfectivo)
                .WithRequired(c => c.Retiro);
            HasOptional(c => c.Pantalla)
                .WithRequired(c => c.Retiro);
            HasOptional(c => c.BaseDatos)
                .WithRequired(c => c.Retiro);
        }
    }
}
