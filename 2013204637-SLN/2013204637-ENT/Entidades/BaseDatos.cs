using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class BaseDatos
    {
        
        private List<Cuenta> _Cuentas;
        public List<Cuenta> Cuentas
        {
            get { return _Cuentas; }
            set { _Cuentas = value; }
        }

        public BaseDatos()
        {
            Cuentas = new List<Cuenta>();
        }

        

        public BaseDatos(int maxNumCuentas)
        {
            
            Cuentas = new List<Cuenta>(maxNumCuentas);
        }

        public bool AutenticarUsuario(int numeroCuenta,int pin)
        {
            
            int max= _Cuentas.Count;
            //_Cuentas.ForEach(if numeroCuenta==_Cuentas.)
            for (int i = 0; i <= max; i++ )
            {
                if (_Cuentas[i].NumeroCuenta == numeroCuenta && _Cuentas[i].Pin == pin)
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            return false;
        }

        public decimal ObtenerSaldoDisponible(int numeroCuenta)
        {
            int max = _Cuentas.Count;
            for (int i = 0; i <= max; i++)
            {
                if (_Cuentas[i].NumeroCuenta == numeroCuenta)
                {
                    return _Cuentas[i].Monto;
                }
                else
                {
                    return 0.0M;
                }
            }
            return 0.0M;
        }

        public void Debitar(int numeroCuenta, decimal monto)
        {
            //aqui iria el codigo de la transacion Deposito
            //esa transaccion no existe en el sistema actual segun las diapositivas
        }

        public void Creditar(int numeroCuenta, decimal monto)
        {
            //esta transaccion es el retiro de dinero de la cuenta
            int max = _Cuentas.Count;
            for (int i = 0; i < max; i++)
            {
                if (_Cuentas[i].NumeroCuenta == numeroCuenta)
                {
                    //luego de encontrar la cuenta con ese numero de cuenta le resta el monto
                    _Cuentas[i].Monto -= monto;

                }
                
            }

        }
    }
}
