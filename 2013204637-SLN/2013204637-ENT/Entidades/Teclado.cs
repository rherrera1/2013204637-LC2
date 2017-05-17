using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class Teclado
    {
        private int _NumeroCuenta;
        private int _Pin;

        public int NumeroCuenta
        {
            get { return _NumeroCuenta; }
            set { _NumeroCuenta = value; }
        }

        public int Pin
        {
            get { return _Pin; }
            set { _Pin = value; }
        }

        public Teclado()
        {

        }
        public Teclado(int numeroCuenta,int pin)
        {
            NumeroCuenta = numeroCuenta;
            Pin = pin;
        }
    }
}
