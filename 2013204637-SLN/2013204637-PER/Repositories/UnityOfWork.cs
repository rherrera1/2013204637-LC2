using _2013204637_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly _2013204637_SLNDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();
        

        public IATMRepository ATMs{get;private set; }
        public IBaseDatosRepository BaseDatos_s{get;private set;}
        public ICuentaRepository Cuentas{get;private set;}
        public IDispensadorEfectivoRepository DispensadorEfectivo_s { get; private set; }
        public IPantallaRepository Pantallas { get; private set; }
        public IRanuraDepositoRepository RanuraDeposito_s { get; private set; }
        public IRetiroRepository Retiros { get; private set; }
        public ITecladoRepository Teclados { get; private set; }

        //ctores

        private UnityOfWork()
        {
            _Context = new _2013204637_SLNDbContext();
           
            ATMs = new ATMRepository(_Context);
            BaseDatos_s = new BaseDatosRepository(_Context);
            Cuentas = new CuentaRepository(_Context);
            DispensadorEfectivo_s = new DispensadorEfectivoRepository(_Context);
            Pantallas = new PantallaRepository(_Context);
            RanuraDeposito_s = new RanuraDepositoRepository(_Context);
            Retiros = new RetiroRepository(_Context);
            Teclados = new TecladoRepository(_Context);
        }


        public static UnityOfWork Instance
        {
            get
            {
                lock(_Lock)
                {
                    if (_Instance == null)
                    _Instance = new UnityOfWork();
                }
                return _Instance;
            }
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
