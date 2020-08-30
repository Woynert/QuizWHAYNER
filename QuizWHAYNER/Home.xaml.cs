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

namespace QuizWHAYNER
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    /// 
    
    public partial class Home : Page
    {
        int[,] Pnj = new int[10, 6];
        /*
        0 -> especie
        1 -> clase
        2 -> fuerza
        3 -> agilidad
        4 -> percepcion
        5 -> denfesa
        */

        readonly String[] Especie = new String[] {"Humano", "Elfo", "Duende", "Troll", "No muerto"};
        /*
        0 -> humano
        1 -> elfo
        2 -> duende
        3 -> troll
        4 -> no muerto
        */

        readonly String[] Clase = new String[] { "Guerrero", "Arquero", "Mago", "Invocador"};
        /*
        0 -> Guerrero
        1 -> Arquero
        2 -> Mago
        3 -> Invocador
        */

        public Home()
        {
            InitializeComponent();
            lblAlertName.Visibility = Visibility.Hidden;
        }

        //Png information
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblValueNombre.Content = lbxPersonajes.SelectedItem;
            lblValueEspecie.Content = Especie[Pnj[lbxPersonajes.SelectedIndex, 0]];
            lblValueClase.Content = Clase[Pnj[lbxPersonajes.SelectedIndex, 1]];
            lblValueFuerza.Content = Pnj[lbxPersonajes.SelectedIndex, 2];
            lblValueAgilidad.Content = Pnj[lbxPersonajes.SelectedIndex, 3];
            lblValuePercepcion.Content = Pnj[lbxPersonajes.SelectedIndex, 4];
            lblValueDefensa.Content = Pnj[lbxPersonajes.SelectedIndex, 5];
            imgPnj.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/" + Pnj[lbxPersonajes.SelectedIndex, 0].ToString() + ".png", UriKind.RelativeOrAbsolute));

        }

        //Sliders and Labels
        private void sldFuerza_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblFuerza.Content = sldFuerza.Value.ToString();
        }

        private void sldAgilidad_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblAgilidad.Content = sldAgilidad.Value.ToString();
        }

        private void sldPercepcion_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblPercepcion.Content = sldPercepcion.Value.ToString();
        }

        private void sldDefensa_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblDefensa.Content = sldDefensa.Value.ToString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            bool duplicado = false;

            if (lbxPersonajes.Items.Count < 10) { 
                if (txtNombre.Text.Replace(" ", "") != "")
                { //con nombre
                    if (lbxPersonajes.Items.Count > 0)
                    {
                        for (int i = 0; i < lbxPersonajes.Items.Count; i++)
                        {
                            if (txtNombre.Text == lbxPersonajes.Items[i].ToString())
                            {
                                duplicado = true;
                            }
                        }
                    }

                    if (duplicado)
                    {
                        lblAlertName.Content = "Nombre ya existente";
                        lblAlertName.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        Pnj[lbxPersonajes.Items.Count, 0] = cbxEspecie.SelectedIndex;
                        Pnj[lbxPersonajes.Items.Count, 1] = cbxClase.SelectedIndex;
                        Pnj[lbxPersonajes.Items.Count, 2] = Convert.ToInt32(sldFuerza.Value);
                        Pnj[lbxPersonajes.Items.Count, 3] = Convert.ToInt32(sldAgilidad.Value);
                        Pnj[lbxPersonajes.Items.Count, 4] = Convert.ToInt32(sldPercepcion.Value);
                        Pnj[lbxPersonajes.Items.Count, 5] = Convert.ToInt32(sldDefensa.Value);
                        lbxPersonajes.Items.Add(txtNombre.Text);

                        lblPnjLimit.Content = lbxPersonajes.Items.Count + " / 10";

                        //reset
                        lblAlertName.Visibility = Visibility.Hidden;
                        lbxPersonajes.SelectedIndex = lbxPersonajes.Items.Count - 1;
                        cbxEspecie.SelectedIndex = 0;
                        cbxClase.SelectedIndex = 0;
                        sldFuerza.Value = 0;
                        sldAgilidad.Value = 0;
                        sldPercepcion.Value = 0;
                        sldDefensa.Value = 0;
                        txtNombre.Text = "";
                    }
                }
                else //sin nombre
                {
                    lblAlertName.Content = "Falta el Nombre";
                    lblAlertName.Visibility = Visibility.Visible;
                }
            }
            else //sin espacio
            {
                lblAlertName.Content = "Has alcanzado el limite"; 
                lblAlertName.Visibility = Visibility.Visible;
            }
        }

        private void lblLogOut_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow w = (MainWindow) Window.GetWindow(this);

            w.frameMain.Content = w.P1;// new Page1();

        }
    }
}
