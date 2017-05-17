using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class Cuenta
    {
        private int _NumeroCuenta;
        private int _Pin;
        private decimal _Monto;


        public int NumeroCuenta
        {
            get 
            { 
                return _NumeroCuenta; 
            }

            set 
            {
                _NumeroCuenta = value; 
            }
        }

        public int Pin
        {
            get { return _Pin; }
            set { _Pin = value; }
        }


        public decimal Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }
        

        public Cuenta()
        {

        }

        public Cuenta(int numeroCuenta,int pin,decimal monto)
        {
            NumeroCuenta = numeroCuenta;
            Pin = pin;
            Monto = monto;
        }
    }
}
