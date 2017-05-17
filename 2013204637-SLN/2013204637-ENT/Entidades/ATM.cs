using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class ATM
    {
        //los objetos de las clases con las que se relaciona
        private RanuraDeposito _RanuraDeposito;
        private Teclado _Teclado;
        private Pantalla _Pantalla;
        private DispensadorEfectivo _DispensadorEfectivo;
        public BaseDatos BaseDatos { get; set; }

        public RanuraDeposito RanuraDeposito
        {
            get { return _RanuraDeposito; }
            set { _RanuraDeposito = value; }
        }

        public Teclado Teclado
        {
            get { return _Teclado; }
            set { _Teclado = value; }
        }

        public Pantalla Pantalla
        {
            get { return _Pantalla; }
            set { _Pantalla = value; }
        }

        public DispensadorEfectivo DispensadorEfectivo
        {
            get { return _DispensadorEfectivo; }
            set { _DispensadorEfectivo = value; }
        }

        
        public ATM()
        {
            _RanuraDeposito = new RanuraDeposito();
            _Teclado = new Teclado();
            _Pantalla=new Pantalla();
        }

        public ATM(BaseDatos baseDatos)
        {
            
            BaseDatos = baseDatos;
        }

        
    }
}
