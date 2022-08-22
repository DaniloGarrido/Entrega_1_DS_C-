/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using OnBreak.Negocios;


namespace OnBreak.View
{
    /// <summary>
    /// Lógica de interacción para Administracion_clientes.xaml
    /// </summary>
    public partial class Administracion_clientes : MetroWindow
    {
        public Administracion_clientes()
        {
            InitializeComponent();
            
            cmbTipoEmpresa.ItemsSource = Enum.GetValues(typeof(Tipo_Empresa));
            cmbActividadEmpresa.ItemsSource = Enum.GetValues(typeof(ActividadEmpresa));
           Limpiar();
        }

        private void Limpiar()
        {
            txtRut.Text = string.Empty;
            txtRazon.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtDirec.Text = string.Empty;
            txtFono.Text = string.Empty;
            cmbTipoEmpresa.SelectedIndex = -1;
            cmbActividadEmpresa.SelectedIndex = -1 ;
            txtRut.Focus();
        }
        
        private void Flyout(object sender, RoutedEventArgs e)
        {
            FlyoutAdmin_cli.IsOpen = true;
        }

        private void btnclick_menu(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow menu = new MainWindow();
            menu.Show();
        }


          private void btnclick_admin_contra(object sender, RoutedEventArgs e)
        {
            this.Close();
            Administracion_clientes admin_cli = new Administracion_clientes();
            admin_cli.Show();
        }

        private void btnclick_lista_cli(object sender, RoutedEventArgs e)
        {
            this.Close();
            Listado_clientes list_cli = new Listado_clientes();
            list_cli.Show();
        }

        private void btnclick_lista_contra(object sender, RoutedEventArgs e)
        {
            this.Close();
            Listado_contratos list_contra = new Listado_contratos();
            list_contra.Show();
        }

        private void lista(Cliente info)
        {

            this.txtRut.Text = info.Rut;
            this.txtRazon.Text = info.RazonSocial;
            this.txtNom.Text = info.NombreContacto;
            this.txtMail.Text = info.MailContacto;
            this.txtDirec.Text = info.Direccion;
            this.txtFono.Text = info.Telefono;
            this.cmbTipoEmpresa.SelectedIndex = info.IdTipoempressa;
            this.cmbActividadEmpresa.SelectedIndex = info.IdActEmpressa;

        }

        private void Dgridlistcli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgridlistcli.SelectedIndex != -1)
            {
                Cliente list_cli = this.dgridlistcli.SelectedItem as Cliente;
                lista(list_cli);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void Expander_dgrid_cli(object sender, RoutedEventArgs e)
        {
            Manejadora cli = new Manejadora();
            List<Cliente> liscli = cli.Listarcliente();
            this.dgridlistcli.ItemsSource = null;
            this.dgridlistcli.ItemsSource = liscli;
        }


        private void Button_Click(object sender, RoutedEventArgs e) //Agregar
        {
            try
            {
                Cliente clie = new Cliente(txtRut.Text, 
                    txtRazon.Text, 
                    txtNom.Text, 
                    txtMail.Text, 
                    txtDirec.Text,
                    txtFono.Text, 
                    cmbTipoEmpresa.SelectedValue.ToString(), cmbActividadEmpresa.SelectedValue.ToString());
                ;
                if (clie.Create())
                {
                    MessageBox.Show("Cliente Creado con Exito", "Creando Cliente");
                }
                else
                {
                    MessageBox.Show("Cliente no pudo ser creado");
                }
                

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error de creacion", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Limpiar();
        }

        private void BtnEliminar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente clie = new Cliente()
                {
                    Rut = txtRut.Text

                };
                if (clie.Delete())
                {
                    Limpiar();
                    MessageBox.Show("Paciente Eliminado ");
                }
                else
                {
                    Limpiar();
                    MessageBox.Show("Paciente no pudo ser eliminado");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
            }
        }
        
        private void BtnBuscar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente clie = new Cliente()
                {
                    Rut = txtRutSearch.Text
                };
                if (clie.Read())
                {
                    Limpiar();
                    txtRut.Text = clie.Rut;
                    txtRazon.Text = clie.RazonSocial;
                    txtNom.Text = clie.NombreContacto;
                    txtMail.Text = clie.MailContacto;
                    txtDirec.Text = clie.Direccion;
                    txtFono.Text = clie.Telefono;
                    Tipo_Empresa te = (Tipo_Empresa)clie.IdTipoempressa;
                    cmbTipoEmpresa.SelectedItem = te;
                    ActividadEmpresa ae = (ActividadEmpresa)clie.IdActEmpressa;
                    cmbActividadEmpresa.SelectedItem = ae;


                }
                else
                {
                    txtRut.Text = string.Empty;
                    txtRazon.Text = string.Empty;
                    txtNom.Text = string.Empty;
                    txtMail.Text = string.Empty;
                    txtDirec.Text = string.Empty;
                    txtFono.Text = string.Empty;
                    cmbTipoEmpresa.SelectedIndex = 0;
                    cmbActividadEmpresa.SelectedIndex = 0;
                    MessageBox.Show("Paciente no encontrado", "Busqueda");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
            }
        }
        


        
        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
            Cliente clie = new Cliente()
                {
                 Rut = txtRut.Text,
                 RazonSocial = txtRazon.Text,
                 NombreContacto = txtNom.Text,
                 MailContacto = txtMail.Text,
                 Direccion = txtDirec.Text,
                 Telefono = txtFono.Text,
                 IdActEmpressa = cmbActividadEmpresa.SelectedIndex,
                 IdTipoempressa = cmbTipoEmpresa.SelectedIndex

                };
                 if (clie.Update())
                       {
                      Limpiar();
                      MessageBox.Show("Cliente Actualizado ", "Modifica Datos");
                         }
                else
                          {
                      MessageBox.Show("Cliente no pudo ser actualizado", "Modifica Datos");
                         }

              }
             catch (Exception zz)
                {
                 MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                 Limpiar();
                 }

        }
        
        private void CboTipoEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using OnBreak.Negocios;
using MahApps.Metro.Controls.Dialogs;

namespace OnBreak.View
{
    /// <summary>
    /// Lógica de interacción para Administracion_clientes.xaml
    /// </summary>
    public partial class Administracion_clientes : MetroWindow
    {
        public Administracion_clientes()
        {
            InitializeComponent();

            cmbTipoEmpresa.ItemsSource = Enum.GetValues(typeof(Tipo_Empresa));
            cmbActividadEmpresa.ItemsSource = Enum.GetValues(typeof(ActividadEmpresa));
            Limpiar();
        }

        private void Limpiar()
        {
            txtRut.Text = string.Empty;
            txtRazon.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtDirec.Text = string.Empty;
            txtFono.Text = string.Empty;
            cmbTipoEmpresa.SelectedIndex = -1;
            cmbActividadEmpresa.SelectedIndex = -1;
            txtRut.Focus();
        }

        private void Flyout(object sender, RoutedEventArgs e)
        {
            FlyoutAdmin_cli.IsOpen = true;
        }

        private void btnclick_menu(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow menu = new MainWindow();
            menu.Show();
        }


        private void btnclick_admin_contra(object sender, RoutedEventArgs e)
        {
            this.Close();
            Administracion_contratos admin_cli = new Administracion_contratos();
            admin_cli.Show();
        }

        private void btnclick_lista_cli(object sender, RoutedEventArgs e)
        {
            this.Close();
            Listado_clientes list_cli = new Listado_clientes();
            list_cli.Show();
        }

        private void btnclick_lista_contra(object sender, RoutedEventArgs e)
        {
            this.Close();
            Listado_contratos list_contra = new Listado_contratos();
            list_contra.Show();
        }

        private void lista(Cliente info)
        {

            this.txtRut.Text = info.Rut;
            this.txtRazon.Text = info.RazonSocial;
            this.txtNom.Text = info.NombreContacto;
            this.txtMail.Text = info.MailContacto;
            this.txtDirec.Text = info.Direccion;
            this.txtFono.Text = info.Telefono;
            this.cmbTipoEmpresa.SelectedIndex = info.IdTipoempressa;
            this.cmbActividadEmpresa.SelectedIndex = info.IdActEmpressa;

        }

        private void Dgridlistcli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgridlistcli.SelectedIndex != -1)
            {
                Cliente list_cli = this.dgridlistcli.SelectedItem as Cliente;
                lista(list_cli);
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void Expander_dgrid_cli(object sender, RoutedEventArgs e)
        {
            Manejadora cli = new Manejadora();
            List<Cliente> liscli = cli.Listarcliente();
            this.dgridlistcli.ItemsSource = null;
            this.dgridlistcli.ItemsSource = liscli;
        }


        private async void Button_Click(object sender, RoutedEventArgs e) //Agregar
        {
            int ab = 0;
            Cliente clien = new Cliente();

            // ab = clien.Rut.Count() ;

            while (ab <= clien.Rut.Count())
            {

                ab = ab + 1;

            }


            try
            {
                Cliente clie = new Cliente(txtRut.Text, txtRazon.Text, txtNom.Text, txtMail.Text, txtDirec.Text,
                    txtFono.Text, cmbTipoEmpresa.SelectedValue.ToString(), cmbActividadEmpresa.SelectedValue.ToString());
                ;
                if (clie.Create())
                {
                    await this.ShowMessageAsync("Cliente Creado con Exito",string.Format ("Creando Cliente"));
                }
                else
                {
                    await this.ShowMessageAsync("Error...",string.Format("Cliente no ha sido creado"));
                }


            }
            catch (ArgumentException)
            {
                await this.ShowMessageAsync("Error...", string.Format("Cliente no ha sido crado, llene todos los campos"));
            }
            Limpiar();
        }

        private void BtnEliminar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente clie = new Cliente()
                {
                    Rut = txtRut.Text

                };
                if (clie.Delete())
                {
                    Limpiar();
                    MessageBox.Show("Paciente Eliminado ");
                }
                else
                {
                    Limpiar();
                    MessageBox.Show("Paciente no pudo ser eliminado");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
            }
        }

        private void BtnBuscar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente clie = new Cliente()
                {
                    Rut = txtRutSearch.Text
                };
                if (clie.Read())
                {
                    Limpiar();
                    txtRut.Text = clie.Rut;
                    txtRazon.Text = clie.RazonSocial;
                    txtNom.Text = clie.NombreContacto;
                    txtMail.Text = clie.MailContacto;
                    txtDirec.Text = clie.Direccion;
                    txtFono.Text = clie.Telefono;
                    Tipo_Empresa te = (Tipo_Empresa)clie.IdTipoempressa;
                    cmbTipoEmpresa.SelectedItem = te;
                    ActividadEmpresa ae = (ActividadEmpresa)clie.IdActEmpressa;
                    cmbActividadEmpresa.SelectedItem = ae;


                }
                else
                {
                    txtRut.Text = string.Empty;
                    txtRazon.Text = string.Empty;
                    txtNom.Text = string.Empty;
                    txtMail.Text = string.Empty;
                    txtDirec.Text = string.Empty;
                    txtFono.Text = string.Empty;
                    cmbTipoEmpresa.SelectedIndex = 0;
                    cmbActividadEmpresa.SelectedIndex = 0;
                    MessageBox.Show("Cliente no encontrado", "Busqueda");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
            }
        }




        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Cliente clie = new Cliente()
                {
                    Rut = txtRut.Text,
                    RazonSocial = txtRazon.Text,
                    NombreContacto = txtNom.Text,
                    MailContacto = txtMail.Text,
                    Direccion = txtDirec.Text,
                    Telefono = txtFono.Text,
                    IdActEmpressa = cmbActividadEmpresa.SelectedIndex,
                    IdTipoempressa = cmbTipoEmpresa.SelectedIndex

                };
                if (clie.Update())
                {
                    Limpiar();
                    MessageBox.Show("Cliente Actualizado ", "Modifica Datos");
                }
                else
                {
                    MessageBox.Show("Cliente no pudo ser actualizado", "Modifica Datos");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Limpiar();
            }

        }

        private void CboTipoEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
