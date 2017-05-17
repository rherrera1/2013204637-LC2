using _2013204637;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.EntitiesConfigurations
{
    public class TecladoConfiguration : EntityTypeConfiguration<Teclado>
    {
        public TecladoConfiguration()
        {
            HasKey(a => a.TecladoId);
            Property(v => v.NumeroCuenta)
                .IsRequired();
            Property(v => v.Pin)
                .IsRequired();
            
        }
    }
}
