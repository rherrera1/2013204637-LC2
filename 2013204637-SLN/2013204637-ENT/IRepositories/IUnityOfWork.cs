using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IATMRepository ATMs { get; }
        IBaseDatosRepository BaseDatos_s { get;  }
        ICuentaRepository Cuentas { get; }
        IDispensadorEfectivoRepository DispensadorEfectivo_s { get;  }
        IPantallaRepository Pantallas { get;  }
        IRanuraDepositoRepository RanuraDeposito_s { get; }
        IRetiroRepository Retiros { get;  }
        ITecladoRepository Teclados { get; }

        int SaveChanges();
    }
}
