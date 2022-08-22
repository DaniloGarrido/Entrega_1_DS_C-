using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Negocios
{
    public class Contrato
    {

        private string _number;

        public string Number
        {
            get { return _number; }
            set {
                if (value.Length > 0)
                {
                    _number = value;
                }
                else
                    throw new ArgumentException("Error...Ingrese un número de contrato válido. ");
            }
        }


        private DateTime _creacion;

        public DateTime Creacion
        {
            get { return _creacion; }
            set {

                _creacion = value;
            }
        }


        private DateTime _termino;

        public DateTime Termino
        {
            get { return _termino; }
            set { _termino = value; }
        }


        private string _rut1;

        public string Rut1
        {
            get { return _rut1; }
            set {
                if (value.Length > 0)
                {
                    _rut1 = value;
                }
                else
                {
                    throw new ArgumentException("Error...Ingrese un rut válido. ");
                }
            }
        }


        private string _idmodalidadd;

        public string IdModalidadd
        {
            get { return _idmodalidadd; }
            set { _idmodalidadd = value; }
        }


        private int _idTipoEventoo;

        public int IdTipoEventoo
        {
            get { return _idTipoEventoo; }
            set { _idTipoEventoo = value; }
        }


        private DateTime _fechahorainicioo;

        public DateTime FechaHoraInicioo
        {
            get { return _fechahorainicioo; }
            set {
                _fechahorainicioo = value;
            }
        }


        private DateTime _fechahoraterminoo;

        public DateTime FechaHoraTerminoo
        {
            get { return _fechahoraterminoo; }
            set { _fechahoraterminoo = value; }
        }


        private int _asistentess;

        public int Asistentess
        {
            get { return _asistentess; }
            set {
                if (value >= 1)
                {
                    _asistentess = value;
                }
                else
                {
                    throw new ArgumentException("Error...Ingrese una cantidad de asistentes valida. ");
                }
            }
        }


        private int _personal;

        public int Personal
        {
            get { return _personal; }
            set {
                if (value >= 2)
                {
                    _personal = value;
                }
                else
                {
                    throw new ArgumentException("Error...Ingrese un personal igual o mayor a 2. ");
                }
            }
        }


        private bool _realizadoo;

        public bool Realizadoo
        {
            get { return _realizadoo; }
            set { _realizadoo = value; }
        }


        private float _valortotal;

        public float ValorTotal
        {
            get { return _valortotal; }
            set { _valortotal = value; }
        }


        private string _observacioness;

        public string Observacioness
        {
            get { return _observacioness; }
            set {
                if (value.Length > 0)
                {
                    _observacioness = value;
                }
                else
                {
                    throw new ArgumentException("Error...Ingrese observación. ");
                }
            }
        }




        public Contrato()
        {
            
        }

        public Contrato(string Numberr, DateTime CreacioN, DateTime TerminO,
            string Rut1, string IdModalidadD,
            int IdTipoEventoO, DateTime FechaHoraInicioO, DateTime FechaHoraTerminoO, int AsistenteS, int Personaal,
            bool Realizadoo, float ValorTotal, string Observacioness)
        {
            this.Number = Numberr;
            this.Creacion = CreacioN;
            this.Termino = TerminO;
            this.Rut1 = Rut1;
            this.IdModalidadd = IdModalidadD;
            this.IdTipoEventoo = IdTipoEventoO;
            this.FechaHoraInicioo = FechaHoraInicioO;
            this.FechaHoraTerminoo = FechaHoraTerminoO;
            this.Asistentess = AsistenteS;
            this.Personal = Personaal;
            this.Realizadoo = Realizadoo;
            this.ValorTotal = ValorTotal;
            this.Observacioness = Observacioness;
        }



        public bool Creates()
        {
            try
            {
                Datos.Contrato contra = new Datos.Contrato()
                {
                    Numero = this.Number,
                   Creacion = this.Creacion,
                   Termino = this.Termino,
                    RutCliente = this.Rut1,
                    IdModalidad = this.IdModalidadd,
                    IdTipoEvento = this.IdTipoEventoo,
                    FechaHoraInicio = this.FechaHoraInicioo,
                   FechaHoraTermino = this.FechaHoraTerminoo,
                    Asistentes = this.Asistentess,
                    PersonalAdicional = this.Personal,
                    Realizado = this.Realizadoo,
                    ValorTotalContrato = this.ValorTotal,
                    Observaciones = this.Observacioness

                };
                Conexion.Onbreakk.Contrato.Add(contra);
                Conexion.Onbreakk.SaveChanges();
                return true;
            }

            catch
            {
                return false;
            }
        }


        public bool Read()
        {
            try
            {
                Datos.Contrato contra = (from onbrake in Conexion.Onbreakk.Contrato
                                      where onbrake.Numero == this.Number
                                      select onbrake).First();
                this.Number = contra.Numero;
                this.Creacion = contra.Creacion;
                this.Termino = contra.Termino;
                this.Rut1 = contra.RutCliente;
                this.IdModalidadd = contra.IdModalidad;
                this.IdTipoEventoo = contra.IdTipoEvento;
                this.FechaHoraInicioo = contra.FechaHoraInicio;
                this.FechaHoraTerminoo = contra.FechaHoraTermino;
                this.Asistentess = contra.Asistentes;
                this.Personal = contra.PersonalAdicional;
                this.Realizadoo = contra.Realizado;
                this.ValorTotal = Convert.ToSingle(contra.ValorTotalContrato);
                this.Observacioness = contra.Observaciones;
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Update()
        {
            try
            {
                Datos.Contrato contra = Conexion.Onbreakk.Contrato.First(p => p.Numero == this.Number);
                contra.Numero = this.Number;
                contra.Creacion = this.Creacion;
                contra.Termino = this.Termino;
                contra.RutCliente = this.Rut1;
                contra.IdModalidad = this.IdModalidadd;
                contra.IdTipoEvento = this.IdTipoEventoo;
                contra.FechaHoraInicio = this.FechaHoraInicioo;
                contra.FechaHoraTermino = this.FechaHoraTerminoo;
                contra.Asistentes = this.Asistentess;
                contra.PersonalAdicional = this.Personal;
                contra.Realizado = this.Realizadoo;
                contra.ValorTotalContrato = this.ValorTotal;
                contra.Observaciones = this.Observacioness;

                Conexion.Onbreakk.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



        public bool Delete()
        {
            try
            {
                Datos.Contrato contra = (from onbrake in Conexion.Onbreakk.Contrato
                                      where onbrake.Numero == this.Number
                                      select onbrake).First();
                Conexion.Onbreakk.Contrato.Remove(contra);
                Conexion.Onbreakk.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        










    }
}
