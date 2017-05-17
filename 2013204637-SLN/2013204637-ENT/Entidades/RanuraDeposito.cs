using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class RanuraDeposito
    {
        //aqui se guarda el monto de l deposito con la variable deposito
        //esta clase no se usara porque la unica transaccin disponible es de Retiro
        private int _deposito;

        public int deposito
        {
            get { return _deposito; }
            set { _deposito = value; }
        }


        public RanuraDeposito()
        {

        }
        public RanuraDeposito(int CantidadDeposito)
        {
            deposito = CantidadDeposito;
        }
    }
}
