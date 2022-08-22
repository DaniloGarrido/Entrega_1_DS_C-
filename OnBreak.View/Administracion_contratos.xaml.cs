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
using System.Windows.Media.Animation;
namespace OnBreak.View
{
    /// <summary>
    /// Lógica de interacción para Administracion_contratos.xaml
    /// </summary>
    public partial class Administracion_contratos : MetroWindow
    {
        public Administracion_contratos()
        {
            InitializeComponent();
            tipoevent.ItemsSource = Enum.GetValues(typeof(Tipo_Evento));
            
            
            
         //   cmbcock.ItemsSource = Enum.GetValues(typeof(Modalidad_Cocktail));
          //  cmbcena.ItemsSource = Enum.GetValues(typeof(Modalidad_Cena));
        }

        private void btnclickFlyoutAdmin_contra(object sender, RoutedEventArgs e)
        {
            FlyoutAdmin_contra.IsOpen = true;
        }

        private void btnclick_menu(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow menu = new MainWindow();
            menu.Show();
        }

        private void btnclick_admin_cli(object sender, RoutedEventArgs e)
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

        /*private void listacontra(Contrato infocontra)
        {
            //int cboxint = Convert.ToInt32(Modalidad_CofeeBreak.DayBreak);
            this.lblNumContrato.ToolTip = infocontra.Number;
            this.txtrut.Text = infocontra.Rut1;
            this.cboxcofbreakmodalidad = infocontra.IdModalidadd;
            this.txtNom.Text = info.NombreContacto;
            this.txtMail.Text = info.MailContacto;
            this.txtDirec.Text = info.Direccion;
            this.txtFono.Text = info.Telefono;
            this.cboxint = info.IdTipoempressa;
            this.cmbActividadEmpresa.SelectedIndex = info.IdActEmpressa;

        }*/

/*private void Dgridlistcli_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
}*/

/*private void Expander_dgrid_cli(object sender, RoutedEventArgs e)
{
    Manejadora cli = new Manejadora();
    List<Contrato> liscontra = cli.Listarcontrato();
    //this.dgridlistcli.ItemsSource = null;
    this.dgridlistcli.ItemsSource = liscontra;
}

/*private void Button_Click(object sender, RoutedEventArgs e) //AGREGAR
{
    DateTime num = DateTime.Now;
    String n = num.ToString("yyMMddhhmmss");
    Console.WriteLine(n);


    DateTime fec = DateTime.Now;
    fec = DPhorainicio.SelectedDate.Value.AddYears(1);

    bool radi = false;
    if (Radiomix.IsChecked == true)
    {
        radi = true;
    }
    if (Radioveg.IsChecked == true)
    {
        radi = true;
    }
    else
        radi = false;

    try
    {


            Contrato contrato = new Contrato (
                lblNumContrato.ToString(),
                num,
                Convert.ToDateTime(DPcreacion),
                txtrut.Text,
                cboxcofbreakmodalidad.ToString(),


                DPhorainicio.SelectedDate.Value,
                fec,
                radi,
                DPhorainicio


   );
        if (contrato.Creates())
        {
            MessageBox.Show("Contrato Creado con exito");
        }
        else
        {
            MessageBox.Show("No se pudo crear Contrato");
        }
    }
    catch (Exception zz)
    {
        MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }
    //Limpiar();
}*/
/*}



}*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;
//using System.Windows.Forms;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
namespace OnBreak.View
{
    /// <summary>
    /// Lógica de interacción para Administracion_contratos.xaml
    /// </summary>
    /// 

    public partial class Administracion_contratos : MetroWindow
    {
        private List<Modalidad> modalidfilter = new List<Modalidad>();
        private List<Modalidad> modalid = new List<Modalidad>();

        Manejadora mane = new Manejadora();

        public Administracion_contratos()
        {
            InitializeComponent();
            // Llenarcombo();
           
            //cmbmodalidad.SelectedIndexChanged += new EventHandler(onChangeCombo);
            tipoevent.ItemsSource = Enum.GetValues(typeof(Tipo_Evento));
            //cboxmodalidad.ItemsSource=Enum.GetValues(typeof())

            //   cmbcock.ItemsSource = Enum.GetValues(typeof(Modalidad_Cocktail));
            //  cmbcena.ItemsSource = Enum.GetValues(typeof(Modalidad_Cena));
        }
        private void Expander_dgrid_cli(object sender, RoutedEventArgs e)
        {
            Manejadora cli = new Manejadora();
            List<Contrato> liscontra = cli.Listarcontrato();
            //this.dgridlistcli.ItemsSource = null;
            this.dgridlistcli.ItemsSource = liscontra;
        }




        public void llenarcmbModalidad(int idTipo)
        {
            modalidfilter = new List<Modalidad>();
            foreach (Modalidad con in modalid)
            {

                if (con.Idtipo == idTipo)
                {
                    modalidfilter.Add(con);
                }
            }


            cboxmodalidad.ItemsSource = modalidfilter;
            cboxmodalidad.DisplayMemberPath = "Nombre";
            cboxmodalidad.SelectedValuePath = "IdModalida";

            //   cmbmodalidad.Datasource = modalidfilter;
            //   cmbmodalidad.DisplaayMember = "Nombre";
            //   cmbmodalidad.ValueMember = "IdModalida";


        }





     

        private void btnclickFlyoutAdmin_contra(object sender, RoutedEventArgs e)
        {
            FlyoutAdmin_contra.IsOpen = true;
        }

        private void btnclick_menu(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow menu = new MainWindow();
            menu.Show();
        }

        private void btnclick_admin_cli(object sender, RoutedEventArgs e)
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


        /*private void Button_Click(object sender, RoutedEventArgs e) //AGREGAR
        {
            DateTime num = DateTime.Now;
            String n = num.ToString("yyMMddhhmmss");
            Console.WriteLine(n);
            tipoevent.SelectionChanged += onchangecombou;

            DateTime fec = DateTime.Now;
            fec = DPhorainicio.SelectedDate.Value.AddYears(1);

            bool radi = false;
            if (cboxmodalidad.SelectedIndex == 0)
            {
                rbdprueba.IsEnabled = false;
            }


          //  if (rbdrealizado.IsChecked == true)
           // {
        //        radi = true;
         //   }
         //   else
          //      radi = false;



            try
            {
                Contrato contrato = new Contrato(
                    lblNumContrato.ToString(), DPcreacion.SelectedDate.Value,
                    DPtermino.SelectedDate.Value, txtrut.Text, cboxmodalidad.SelectedValue.ToString(),
                    tipoevent.SelectedIndex, DPhorainicio.SelectedDate.Value,
                    DPhoratermino.SelectedDate.Value,
                    int.Parse(txtasist.Text), int.Parse(txtpersonal.Text), radi,
                    Convert.ToSingle(lbltotal.ToString()), txtobservaciones.Text

            );
                if (contrato.Creates())
                {
                    MessageBox.Show("Contrato Creado con exito");
                }
                else
                {
                    MessageBox.Show("No se pudo crear Contrato");
                }
            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //Limpiar();
        }*/


        private void onchangecombou(object sender, EventArgs e)
        {


            int idTipoevent = int.Parse(tipoevent.SelectedValue.ToString());
            llenarcmbModalidad(idTipoevent);

        }



        private void Tipoevent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
            if (tipoevent.SelectedIndex==0)
            {
                
                cboxmodalidad.Items.Clear();
                cboxmodalidad.ItemsSource = null;
                cboxmodalidad.Items.Add(Modalidad_CofeeBreak.DayBreak);
                cboxmodalidad.Items.Add(Modalidad_CofeeBreak.JournalBreak);
                cboxmodalidad.Items.Add(Modalidad_CofeeBreak.LigthBreak);                
                Radioveg.IsEnabled = true;
                Radiomix.IsEnabled = true;
                rdbbasica.IsEnabled=false;
                rdbno.IsEnabled = false;
                rdbpersonal.IsEnabled = false;
                rdbmusicno.IsEnabled = false;
                rdbmusicsi.IsEnabled = false;
                //lblnum.Content=(null);
               // lblnum.Content =  "hola";
              

            }
            else if (tipoevent.SelectedIndex == 1)
            {
                cboxmodalidad.Items.Clear();
                cboxmodalidad.ItemsSource = null;
                cboxmodalidad.Items.Add(Modalidad_Cocktail.QuickCocktail);
                cboxmodalidad.Items.Add(Modalidad_Cocktail.AmbientCocktail);
                Radioveg.IsEnabled = false;
                Radiomix.IsEnabled = false;
                rdbbasica.IsEnabled = true;
                rdbno.IsEnabled = true;
                rdbpersonal.IsEnabled = true;
                rdbmusicno.IsEnabled = true;
                rdbmusicsi.IsEnabled = true;

            }
            else if (tipoevent.SelectedIndex == 2)
            {
                cboxmodalidad.Items.Clear();
                cboxmodalidad.ItemsSource = null;
                cboxmodalidad.Items.Add(Modalidad_Cena.Ejecutiva);
                cboxmodalidad.Items.Add(Modalidad_Cena.Celebracion);
                Radioveg.IsEnabled = false;
                Radiomix.IsEnabled = false;
                rdbbasica.IsEnabled = true;
                rdbno.IsEnabled = false;
                rdbpersonal.IsEnabled = true;
                rdbmusicno.IsEnabled = true;
                rdbmusicsi.IsEnabled = true;

            }
        }


        private void btningresar(object sender, RoutedEventArgs e) //CREAR
        {




            
            //   DateTime num = DateTime.Now;
            //   String n = num.ToString("yyMMddhhmmss");
            //   Console.WriteLine(n);


            //    DateTime fec = DateTime.Now;
            //    fec = DPcreacion.SelectedDate.Value.AddYears(1);

            // bool radi = false;
            //if (realizado.IsChecked == true)
            //{
            //radi = true;
            //}
            //else
            //radi = false;



            /*
            int ab = 0;

            Contrato contr = new Contrato();

            ab = Convert.ToInt32(contr.Number);
            while (ab <= 999999999)
            {
                ab = ab + 1;
                txtnro.Text = ab.ToString();
            }
            */




            float tot = float.Parse(lbltotal.Content.ToString());

            try
            {
                Contrato contrato = new Contrato
                    (
                    lblNumContrato.Text,
                    DPcreacion.SelectedDateTime.Value,
                    DPtermino.SelectedDateTime.Value,
                    txtrut.Text,
                    Convert.ToString(cboxmodalidad.SelectedIndex),
                    tipoevent.SelectedIndex,
                    DPhorainicio.SelectedDateTime.Value,
                    DPhoratermino.SelectedDateTime.Value,
                    Convert.ToInt32(txtasist.Text),
                    Convert.ToInt32(txtpersonal.Text),
                    
                    realizado.IsChecked==true,
                    
                    tot,
                    txtobservaciones.Text

            );
                if (contrato.Creates())
                {

                    MessageBox.Show("Contrato Creado con exito");

                }
                else
                {
                    MessageBox.Show("No se pudo crear Contrato");
                }
            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }





        private void Total_Click(object sender, RoutedEventArgs e)
        {
            //int valortipevent = int.Parse(tipoevent.SelectionBoxItem);
          //  int valormodali = int.Parse(cboxmodalidad.Text);
            int valortxtpersonal=int.Parse(txtpersonal.Text);
            int valortxtasisten = int.Parse(txtasist.Text);
            double UF = 28675.77;
            lbltotal.Content = null;

            //modalidad light break coffee break
            //Entre 1 y 20
            if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex==0 && tipoevent.SelectedIndex==0 )
            {

                lbltotal.Content = (UF*3)+(UF *3)+(UF*2);
            }
            else  if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 3) + (UF * 3) + (UF * 3);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 3) + (UF * 3) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal >4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content =  (UF * 3) + (UF * 3)+(UF * 3.5)+((UF*0.5)*valortxtpersonal); 
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 0)
            {

                lbltotal.Content = (UF * 3) + (UF * 5)+(UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 0)
            { 
                lbltotal.Content = (UF * 3) + (UF * 5) + (UF * 3);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex==0 && tipoevent.SelectedIndex==0)
            {
                lbltotal.Content = UF* (UF * 3) + (UF * 5) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 3) + (UF * 5) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }
            //mas de 50

            /*else if (valortxtasisten >50  && valortxtpersonal == 2)
            {

                lbltotal.Content = (UF * 3) + (UF * 5) +(UF * 2);
            }
            else if (valortxtasisten >50 && valortxtpersonal == 3)
            {
                lbltotal.Content = (UF * 3) + (UF * 5) + (UF * 3);
            }
            else if (valortxtasisten >50 && valortxtpersonal == 4)
            {
                lbltotal.Content = UF * (UF * 3) + (UF * 5) + (UF * 3.5);
            }
            else if (valortxtasisten >50 && valortxtpersonal > 4)
            {
                lbltotal.Content = (UF * 3) + (UF * 5) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }*/
            //modalidad journal break coffee break
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 0)
            {

                lbltotal.Content = (UF * 8) + (UF * 3) + (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 8) + (UF * 3) + (UF * 3);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 8) + (UF * 3) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 8) + (UF * 3) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 0)
            {

                lbltotal.Content = (UF * 8) + (UF * 5) + (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 8) + (UF * 5) + (UF * 3);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = UF * (UF * 8) + (UF * 5) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 8) + (UF * 5) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }
            //modalidad day break coffee break
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 2 && tipoevent.SelectedIndex == 0)
            {

                lbltotal.Content = (UF * 12) + (UF * 3) + (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 2 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 12) + (UF * 3) + (UF * 3);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 2 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 12) + (UF * 3) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 2 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 12) + (UF * 3) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 2 && tipoevent.SelectedIndex == 0)
            {

                lbltotal.Content = (UF * 12) + (UF * 5) + (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 2 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 12) + (UF * 5) + (UF * 3);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 2 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 12) + (UF * 5) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 2 && tipoevent.SelectedIndex == 0)
            {
                lbltotal.Content = (UF * 12) + (UF * 5) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }



            //modalidad quick cocktail cocktail sin musica ni ambientacion
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked==true  && rdbno.IsChecked==true)
            {

                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4)+ (UF * 3.5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex ==0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {

                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }
            //modalidad quick cocktail cocktail con musica sin ambientacion
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true  && rdbno.IsChecked == true)
            {

                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 2)+(UF*1);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3) + (UF * 1);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + (UF * 1);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal) + (UF * 1);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            { 
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 2) + (UF * 1);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3) + (UF * 1);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + (UF * 1);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal) + (UF * 1);
            }
            //modalidad quick cocktail cocktail con musica y ambientacion basica
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked==true)
            {

                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 2) + (UF * 1)+(UF*2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3) + (UF * 1) + (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + (UF * 1) + (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal) + (UF * 1) + (UF * 2);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {

                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 2) + (UF * 1) + (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3) + (UF * 1) + (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + (UF * 1) + (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal) + (UF * 1) + (UF * 2);
            }
            //modalidad quick cocktail cocktail sin musica y ambientacion basica
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {

                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 2) +  (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3) +  (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal) + (UF * 2);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {

                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 2) +  (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3) + (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) +  (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal) + (UF * 2);
            }
            //modalidad quick cocktail cocktail con musica y ambientacion Personalizada
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {

                lbltotal.Content = (UF * 18); //+ (UF * 4) + (UF * 2) + (UF * 1) + (UF * 5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 19);// + (UF * 4) + (UF * 3) + (UF * 1) + (UF * 5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 19.5);//+ (UF * 4) + (UF * 3.5) + (UF * 1) + (UF * 5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal) + (UF * 1) + (UF * 5);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {

                lbltotal.Content = (UF * 20);// + (UF * 6) + (UF * 2) + (UF * 1) + (UF * 5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 21);// + (UF * 6) + (UF * 3) + (UF * 1) + (UF * 5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 21.5);// + (UF * 6) + (UF * 3.5) + (UF * 1) + (UF * 5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal) + (UF * 1) + (UF * 5);
            }
            //modalidad quick cocktail cocktail sin musica y ambientacion Personalizada
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {

                lbltotal.Content = (UF * 17);// + (UF * 4) + (UF * 2)  + (UF * 5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 18);// + (UF * 4) + (UF * 3) + (UF * 5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 18.5);// + (UF * 4) + (UF * 3.5) + (UF * 5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal) +  (UF * 5);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {

                lbltotal.Content = (UF * 19);// + (UF * 6) + (UF * 2) +  (UF * 5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 20);// + (UF * 6) + (UF * 3) +  (UF * 5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 21.5);// + (UF * 6) + (UF * 3.5) +  (UF * 5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal) +  (UF * 5);
            }
            //modalidad Ambient Cocktail Cocktail Sin Musica ni ambientacion
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {

                lbltotal.Content = (UF * 16);// + (UF * 4) + (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 17);// + (UF * 4) + (UF * 3);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 17.5);// + (UF * 4) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex ==1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 10) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {

                lbltotal.Content = (UF * 18);// + (UF * 6) + (UF * 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 19);// + (UF * 6) + (UF * 3);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 19.5);// + (UF * 6) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 10) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }
            //modalidad Ambient Cocktail Cocktail Con Musica sin ambientacion
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {

                lbltotal.Content = (UF * 17);// + (UF * 4) + (UF * 2)+(UF+1);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 18);// + (UF * 4) + (UF * 3) + (UF + 1);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1  && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 18.5);// + (UF * 4) + (UF * 3.5)+(UF+1);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 10) + (UF * 4 ) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

            if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {

                lbltotal.Content = (UF * 19);// + (UF * 6) + (UF * 2) + (UF + 1);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 20);// + (UF * 6) + (UF * 3) + (UF + 1);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 20.5);// + (UF * 6) + (UF * 3.5) + (UF + 1);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbno.IsChecked == true)
            {
                lbltotal.Content = (UF * 10) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); 
            }          
            
            //modalidad Ambient Cocktail Cocktail Con Musica y ambientacion basica
            //Entre 1 y 20
            if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {

                lbltotal.Content = (UF * 19);// (UF * 10) + (UF * 4) + (UF * 2)+ (UF + 1)+(UF+2) ;
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 20);// (UF * 10) + (UF * 4) + (UF * 3)+ (UF + 1)+(UF+2) ;
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 20.5);// (UF*10)+ (UF * 4) + (UF * 3.5)+ (UF + 1)+(UF+2) ;
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 10) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

            if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {

                lbltotal.Content = (UF * 21);// (UF * 10) + (UF * 6) + (UF * 2) + (UF + 1) + (UF + 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 22);// (UF * 10) + (UF * 6) + (UF * 3) + (UF + 1) + (UF + 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 21.5);// (UF * 10) + (UF * 6) + (UF * 3.5) + (UF + 1) + (UF + 2);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }
            //modalidad Ambient Cocktail Cocktail sin Musica y ambientacion basica
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {

                lbltotal.Content = (UF * 18);// (UF * 10) + (UF * 4) + (UF * 2)+ (UF+2) ;
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 19);// (UF * 10) + (UF * 4) + (UF * 3)+ (UF+2) ;
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 19.5); // (UF * 10) + (UF * 4) + (UF * 3.5)+ (UF+2) ;
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 10) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

            if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {

                lbltotal.Content = (UF * 20);// (UF * 10) + (UF * 6) + (UF * 2)+ (UF+2) ;
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 21);// (UF * 10) + (UF * 6) + (UF * 3)+ (UF+2) ;
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 21.5);// (UF * 10) + (UF * 6) + (UF * 3.5)+ (UF+2) ;
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }
            //modalidad Ambient Cocktail Cocktail con Musica y ambientacion personalizada
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {

                lbltotal.Content = (UF * 22);//(UF * 10) + (UF * 4) + (UF * 2)+(UF*1)+(UF*5)
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 23);//(UF * 10) + (UF * 4) + (UF * 2)+(UF*1)+(UF*5)
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 24);//(UF * 10) + (UF * 4) + (UF * 2)+(UF*1)+(UF*5)
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 10) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }
            
            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {

                lbltotal.Content = (UF *24 );//(UF * 10) + (UF * 6) + (UF * 2)+(UF*1)+(UF*5)
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 25);//(UF * 10) + (UF * 6) + (UF * 3)+(UF*1)+(UF*5)
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 25.5);//(UF * 10) + (UF * 6) + (UF * 3.5)+(UF*1)+(UF*5)
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicsi.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }

            //modalidad Ambient Cocktail, Cocktail sin Musica y ambientacion personalizada
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {

                lbltotal.Content = (UF * 21);//(UF * 10) + (UF * 4) + (UF * 2)+(UF*5)
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 22);//(UF * 10) + (UF * 4) + (UF * 3)+(UF*5)
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 22.5);//(UF * 10) + (UF * 4) + (UF * 3.5)+(UF*5)
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 10) + (UF * 4) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

            if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {

                lbltotal.Content = (UF * 23);//(UF * 10) + (UF * 6) + (UF * 2)+(UF*5)
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 24);//(UF * 10) + (UF * 6) + (UF * 3)+(UF*5)
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 24.5);//(UF * 10) + (UF * 6) + (UF * 3.5)+(UF*5)
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 1 && rdbmusicno.IsChecked == true && rdbpersonal.IsChecked == true)
            {
                lbltotal.Content = (UF * 6) + (UF * 6) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }







            //modalidad Ejecutiva Cenas sin musica con ambientacion basica
            //Entre 1 y 20
             if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 2 && rdbmusicno.IsChecked == true && rdbbasica.IsChecked == true)
            {

                lbltotal.Content = (UF * 25) + ((UF *1.5)*valortxtasisten ) + (UF * 3)+ (UF*3);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 25) + ((UF * 1.5) * valortxtasisten) + (UF * 3);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 25) + ((UF * 1.5) * valortxtasisten) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 25) + ((UF * 1.5) * valortxtasisten) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

             if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex ==2)
            {

                lbltotal.Content = (UF * 25) + ((UF * 1.2) * valortxtasisten) + (UF * 3);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 25) + ((UF * 1.2) * valortxtasisten) + (UF * 4);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 25) + ((UF * 1.2) * valortxtasisten) + (UF * 5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 0 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 25) + ((UF * 1.2) * valortxtasisten) + (UF * 3.5)+((UF / 2) * valortxtpersonal); ;
            }
            //modalidad Celebracion Cenas
            //Entre 1 y 20
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 2)
            {

                lbltotal.Content = (UF * 35) + ((UF * 1.5) * valortxtasisten) + (UF * 2);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 35) + ((UF * 1.5) * valortxtasisten) + (UF * 3);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 35) + ((UF * 1.5) * valortxtasisten) + (UF * 3.5);
            }
            else if ((valortxtasisten >= 1 || valortxtasisten <= 20) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 35) + ((UF * 1.5) * valortxtasisten) + (UF * 3.5) + ((UF * 0.5) * valortxtpersonal);
            }

            //entre 21 y 50

            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 2 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 2)
            {

                lbltotal.Content = (UF * 35) + ((UF * 1.2) * valortxtasisten) + (UF * 3);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 3 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 35) + ((UF * 1.2) * valortxtasisten) + (UF * 4);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal == 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 35) + ((UF * 1.2) * valortxtasisten) + (UF * 5);
            }
            else if ((valortxtasisten >= 21 || valortxtasisten <= 50) && valortxtpersonal > 4 && cboxmodalidad.SelectedIndex == 1 && tipoevent.SelectedIndex == 2)
            {
                lbltotal.Content = (UF * 35) + ((UF * 1.2) * valortxtasisten) + (UF * 3.5) + ((UF / 2) * valortxtpersonal); ;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contrato contra = new Contrato();
                {
                    contra.Number = lblNumContrato.Text;
                };
                if (norealizado.IsChecked == true)
                {

                    MessageBox.Show("Contrato Terminado. Como no Realizado ");
                }
                else
                {
                    MessageBox.Show("Contrato no pudo ser terminado, debe dar click en el boton no realizado.");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Contrato contra = new Contrato();
                {
                    contra.Number = lblNumContrato.Text;
                };
                if (realizado.IsChecked == true)
                {

                    MessageBox.Show("Contrato Terminado. ");
                }
                else
                {
                    MessageBox.Show("Contrato no pudo ser terminado, debe dar click en el boton no realizado.");
                }

            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }


        }

        private void Btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contrato contra = new Contrato();
                {
                    contra.Number = txtnrosearch.Text;
                }
                if (contra.Read())
                {
                    lblNumContrato.Text = contra.Number;
                    DPcreacion.SelectedDateTime = contra.Creacion;
                    DPtermino.SelectedDateTime = contra.Termino;
                    txtrut.Text = contra.Rut1;
                    DPhorainicio.SelectedDateTime = contra.FechaHoraInicioo;
                    DPhoratermino.SelectedDateTime= contra.FechaHoraTerminoo;
                    int assis;
                    int.TryParse(txtasist.Text, out assis);
                    contra.Asistentess = assis;
                    int pnal;
                    int.TryParse(txtpersonal.Text, out pnal);
                    contra.Personal = pnal;
                    // int vtotal;
                    //int.TryParse(lbltotal.Content, out vtotal);
                    //contra.ValorTotal = vtotal;
                    lbltotal.Content = contra.ValorTotal;
                    txtobservaciones.Text = contra.Observacioness;
                    
                }
                else
                {
                    lblNumContrato.Text = string.Empty;
                    DPcreacion.SelectedDateTime = null;
                    DPtermino.SelectedDateTime = null;
                    txtrut.Text = string.Empty;
                    DPhorainicio.SelectedDateTime = null;
                    DPhoratermino.SelectedDateTime = null;
                    txtasist.Text = string.Empty;
                    txtpersonal.Text = string.Empty;
                    lbltotal.Content = string.Empty;
                    txtobservaciones.Text = string.Empty;
                }
            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void btnmodificar(object sender, RoutedEventArgs e)
        {
            try
            {
                Contrato con = new Contrato()
                {
                    Number = lblNumContrato.Text,
                    Creacion = DPcreacion.SelectedDateTime.Value,
                    Termino = DPtermino.SelectedDateTime.Value,
                    Rut1 = txtrut.Text,
                    FechaHoraInicioo = DPhorainicio.SelectedDateTime.Value,
                    FechaHoraTerminoo = DPhoratermino.SelectedDateTime.Value

                };

                if (con.Update())
                {
                    MessageBox.Show("actualizado");

                }
                else
                {
                    MessageBox.Show("No se ha Actualizado");
                }
            }
            catch (Exception zz)
            {
                MessageBox.Show(zz.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }



}
