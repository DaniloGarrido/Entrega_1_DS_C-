using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Negocios
{
    public class Modalidad
    {

        private string _idmodalida;

        public string IdModalida
        {
            get { return _idmodalida; }
            set { _idmodalida = value; }
        }

        private int _idtipo;

        public int Idtipo
        {
            get { return _idtipo; }
            set { _idtipo = value; }
        }



        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private double _valorb;

        public double Valorb
        {
            get { return _valorb; }
            set { _valorb = value; }
        }


        private int _personalb;

        public int PersonalB
        {
            get { return _personalb; }
            set { _personalb = value; }
        }



        public Modalidad()
        {
            _idmodalida = string.Empty;
            _idtipo = 0;
            _nombre = string.Empty;
            _valorb = 0;
            _personalb = 0;


        }



        public Modalidad(string idmodalid, int idtipo, string nombre, double valorb, int personalb)
        {
            this.IdModalida = idmodalid;
            this.Idtipo = idtipo;
            this.Nombre = nombre;
            this.Valorb = valorb;
            this.PersonalB = personalb;

        }








    }
}
