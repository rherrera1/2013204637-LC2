using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class DispensadorEfectivo
    {
        public int DispensadorEfectivoId { get; set; }
        private int _Contador = -500;
        public ATM ATM { get; set; }
        public Retiro Retiro { get; set; }

        public int Contador
        {
            get { return _Contador; }
        }

        public DispensadorEfectivo()
        {

        }
    }
}
