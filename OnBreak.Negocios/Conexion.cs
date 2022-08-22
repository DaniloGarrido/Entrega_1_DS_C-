using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.Datos;

namespace OnBreak.Negocios
{
   internal class Conexion
    {
        private static OnBreakEntities _onbreakk;

        public static OnBreakEntities Onbreakk
        {
            get {
                if (_onbreakk == null)
                {
                    _onbreakk = new OnBreakEntities();
                }
                return  _onbreakk;
            }
            set { _onbreakk = value; }
        }
        
    }
}
