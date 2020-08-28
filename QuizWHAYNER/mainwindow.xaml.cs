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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Label invisible
            lblWrong.Visibility = Visibility.Hidden;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text == "Admin" && txtPass.Password == "123")
            {
                MessageBox.Show("Hey");
                lblWrong.Visibility = Visibility.Hidden;
            }
            else if (txtUser.Text == "" || txtPass.Password == "")
            {
                lblWrong.Content = "Por favor, ingrese sus credenciales";
                lblWrong.Visibility = Visibility.Visible;
            }
            else
            {
                lblWrong.Content = "Usuario o contraseña incorrectos";
                lblWrong.Visibility = Visibility.Visible;
            }
        }
    }
}
