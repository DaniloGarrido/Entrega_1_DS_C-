/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.Datos;
namespace OnBreak.Negocios
{
    public class Manejadora
    {
        List<Cliente> listaclientes = new List<Cliente>();

        public List<Cliente> Listarcliente()
        {
            foreach (Datos.Cliente client in Conexion.Onbreakk.Cliente)
            {
                Cliente nuevoCliente = new Cliente(client.RutCliente, client.RazonSocial, client.NombreContacto,
                                                        client.MailContacto, client.Direccion, client.Telefono, client.IdActividadEmpresa.ToString(), client.IdTipoEmpresa.ToString());

                listaclientes.Add(nuevoCliente);

            }
            return listaclientes;
        }



        List<Contrato> listacontrato = new List<Contrato>();

        public List<Contrato> Listarcontrato()
        {
            foreach (Datos.Contrato contra in Conexion.Onbreakk.Contrato)
            {
                Contrato nuevocontrato = new Contrato(contra.Numero, contra.Creacion, contra.Termino, contra.RutCliente, contra.IdModalidad, contra.IdTipoEvento, contra.FechaHoraInicio, contra.FechaHoraTermino, contra.Asistentes, contra.PersonalAdicional, contra.Realizado, contra.ValorTotalContrato, contra.Observaciones);

                listacontrato.Add(nuevocontrato);

            }
            return listacontrato;
        }




    }



}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.Datos;
namespace OnBreak.Negocios
{
    public class Manejadora
    {
        List<Cliente> listaclientes = new List<Cliente>();

        public List<Cliente> Listarcliente()
        {
            foreach (Datos.Cliente client in Conexion.Onbreakk.Cliente)
            {
                Cliente nuevoCliente = new Cliente(client.RutCliente,
                                                    client.RazonSocial, client.NombreContacto,
                                                        client.MailContacto, client.Direccion, client.Telefono, client.IdActividadEmpresa.ToString(), client.IdTipoEmpresa.ToString());

                listaclientes.Add(nuevoCliente);

            }
            return listaclientes;
        }



        List<Contrato> listacontrato = new List<Contrato>();

        public List<Contrato> Listarcontrato()
        {
            foreach (Datos.Contrato contra in Conexion.Onbreakk.Contrato)
            {
                Contrato nuevocontrato = new Contrato(contra.Numero, contra.Creacion, contra.Termino, contra.RutCliente,
                    contra.IdModalidad, contra.IdTipoEvento, contra.FechaHoraInicio, contra.FechaHoraTermino, contra.Asistentes,
                    contra.PersonalAdicional, contra.Realizado, Convert.ToSingle(contra.ValorTotalContrato), contra.Observaciones);

                listacontrato.Add(nuevocontrato);

            }
            return listacontrato;
        }


        List<Modalidad> listamodalidades = new List<Modalidad>();

        public List<Modalidad> ListarModalidad()
        {
            foreach (Datos.ModalidadServicio moda in Conexion.Onbreakk.ModalidadServicio)
            {
                Modalidad nuevomoda = new Modalidad(moda.IdModalidad, moda.IdTipoEvento, moda.Nombre, moda.ValorBase, moda.PersonalBase);
                listamodalidades.Add(nuevomoda);
            }
            return listamodalidades;
        }





    }



}

