using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637
{
    public class Pantalla
    {

        private string _Texto;

        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }
        public Pantalla()
        {

        }
        public Pantalla(string texto)
        {
            Texto = texto;
        }
    }
}
