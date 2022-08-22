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

namespace OnBreak.View
{
    /// <summary>
    /// Lógica de interacción para Listado_clientes.xaml
    /// </summary>
    public partial class Listado_clientes : MetroWindow
    {
        public Listado_clientes()
        {
            InitializeComponent();
        }

   

        private void btnclick_listcli(object sender, RoutedEventArgs e)
        {
            Manejadora cli = new Manejadora();
            List<Cliente> liscli = cli.Listarcliente();
            this.dgridlistcli.ItemsSource = null;
            this.dgridlistcli.ItemsSource = liscli;
        }

 
        /*
private void Button_Click(object sender, RoutedEventArgs e)
{
dgridMostrar.ItemsSource = (
from clie in 
select new
{
  Rut = ent.Rut,
  Nombre = ent.Nombre,
  Edad = ent.Edad,
  Especial = ent.Espe,
  Atencion = ent.Atencion

}
)
.ToList();
}
*/
    }
    
}
