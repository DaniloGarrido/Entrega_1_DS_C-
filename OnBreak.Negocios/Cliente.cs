using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.Negocios
{
    public class Cliente
    {

        private string _rut;

        public string Rut
        {
            get { return _rut; }
            set
            {
                if (value.Length > 0)
                {
                    _rut = value;
                }
                else
                {
                    throw new ArgumentException("Error...Ingrese un rut válido. ");
                }
            }
        }

        private string _razon;

        public string RazonSocial
        {
            get { return _razon; }
            set
            {
                if (value.Length > 0)
                {
                    _razon = value;
                }
                else
                {
                    throw new ArgumentException("Error...Ingrese una Razon sicial valida ");
                }
            }
        }

        private string _nom;

        public string NombreContacto
        {
            get { return _nom; }
            set {
                if (value.Length > 0)
                {
                    _nom = value;
                }
                else
                {
                    throw new ArgumentException("Error.. Debe Ingresar Un Nombre valido.");
                }
            }
        }

        private string _mail;

        public string MailContacto
        {
            get { return _mail; }
            set
            {
                if (value.Length > 0)
                {
                    _mail = value;
                }
                else
                {
                    throw new ArgumentException("Error.. Debe Ingresar Un Email valido.");
                }
            }
        }

        private string _direc;

        public string Direccion
        {
            get { return _direc; }
            set
            {
                if (value.Length > 0)
                {
                    _direc = value;
                }
                else
                {
                    throw new ArgumentException("Error.. Debe Ingresar Una direccion valida.");
                }
            }
        }

        private string _fono;

        public string Telefono
        {
            get { return _fono; }
            set
            {
                if (value.Length > 0)
                {
                    _fono = value;
                }
                else
                {
                    throw new ArgumentException("Error.. Debe Ingresar Un Fono valido.");
                }
            }
        }




        private int _idactempressa;

        public int IdActEmpressa
        {
            get { return _idactempressa; }
            set { _idactempressa = value; }
        }



        private int _idtipoempressa;

        public int IdTipoempressa
        {
            get { return _idtipoempressa; }
            set { _idtipoempressa = value; }
        }






        public Cliente()
        {
            _rut = string.Empty;
            _razon = string.Empty;
            _nom = string.Empty;
            _mail = string.Empty;
            _direc = string.Empty;
            _fono = string.Empty;
            _idtipoempressa = 0;
            _idactempressa = 0;
        }

        public Cliente(string rut, string razon, string nom, string mail, string direc,string fono, string tipoempresa, string actividadempresa)
        {
            this.Rut = rut;
            this.RazonSocial = razon;
            this.NombreContacto = nom;
            this.MailContacto = mail;
            this.Direccion = direc;
            this.Telefono = fono;
            this.IdTipoempressa = (int)((Tipo_Empresa)Enum.Parse(typeof(Tipo_Empresa), tipoempresa));
            this.IdActEmpressa = (int)((ActividadEmpresa)Enum.Parse(typeof(ActividadEmpresa), actividadempresa));
            
        }


        public bool Create()
        {
            try
            {
                Datos.Cliente clie = new Datos.Cliente()
                {
                    
                    RutCliente = this.Rut,
                    RazonSocial = this.RazonSocial,
                    NombreContacto = this.NombreContacto,
                    MailContacto = this.MailContacto,
                    Direccion = this.Direccion,
                    Telefono = this.Telefono,
                    IdActividadEmpresa = this.IdActEmpressa,
                    IdTipoEmpresa = this.IdTipoempressa

                };
                Conexion.Onbreakk.Cliente.Add(clie);
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
                Datos.Cliente clie = (from onbrake in Conexion.Onbreakk.Cliente
                                      where onbrake.RutCliente == this.Rut
                                      select onbrake).First();
                this.Rut = clie.RutCliente;
                this.RazonSocial = clie.RazonSocial;
                this.NombreContacto = clie.NombreContacto;
                this.MailContacto = clie.MailContacto;
                this.Direccion = clie.Direccion;
                this.Telefono = clie.Telefono;
                this.IdTipoempressa = clie.IdTipoEmpresa;
                this.IdActEmpressa = clie.IdActividadEmpresa; 
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
                Datos.Cliente clie = Conexion.Onbreakk.Cliente.First(p => p.RutCliente == this.Rut);
                clie.RutCliente = this.Rut;
                clie.RazonSocial = this.RazonSocial;
                clie.NombreContacto = this.NombreContacto;
                clie.MailContacto = this.MailContacto;
                clie.Direccion = this.Direccion;
                clie.Telefono = this.Telefono;


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
                Datos.Cliente clie = (from onbrake in Conexion.Onbreakk.Cliente
                                      where onbrake.RutCliente == this.Rut
                                      select onbrake).First();
                Conexion.Onbreakk.Cliente.Remove(clie);
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
