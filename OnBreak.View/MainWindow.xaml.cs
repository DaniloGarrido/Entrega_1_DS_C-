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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ControlzEx.Theming;
//using OnBreak.Negocios;

namespace OnBreak.View
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Threading.Thread.Sleep(1500);
        }

        private void Alto_contraste(object sender, RoutedEventArgs e)
        {
            
            ThemeManager.Current.ChangeTheme(this, "Dark.Ligth");


        }

        private void Bajo_Contraste(object sender, RoutedEventArgs e)
        {
            ThemeManager.Current.ChangeTheme(this, "Ligth.Dark");
        }

        private void btnclick_admin_cli(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Administracion_clientes admin_cli = new Administracion_clientes();
            admin_cli.Show();
        }

        private void bntclick_list_cli(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Listado_clientes list_cli = new Listado_clientes();
            list_cli.Show();
        }

        private void bntclick_admin_contra(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Administracion_contratos admin_contra = new Administracion_contratos();
            admin_contra.Show();
        }

        private void bntclick_list_contra(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Listado_contratos list_contra = new Listado_contratos();
            list_contra.Show();
        }
    }
}
