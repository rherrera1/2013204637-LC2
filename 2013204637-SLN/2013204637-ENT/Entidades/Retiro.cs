using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class Retiro
    {
        public Teclado Teclado { get; set; }
        public Pantalla Pantalla { get; set; }
        public DispensadorEfectivo DispensadorEfectivo { get; set; }
        public ATM ATM { get; set; }
        public BaseDatos BaseDatos { get; set; }


        public Retiro()
        {

        }
        public Retiro(Teclado teclado, Pantalla pantalla, DispensadorEfectivo dispensadorEfectivo, ATM aTM, BaseDatos baseDatos)
        {
            Teclado = teclado;
            Pantalla = pantalla;
            DispensadorEfectivo = dispensadorEfectivo;
            ATM = aTM;
            BaseDatos = baseDatos;
        }
    }
}
