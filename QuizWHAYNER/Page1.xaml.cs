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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            lblWrong.Visibility = Visibility.Hidden;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Password == "123")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                //w.frameMain.NavigationService.Navigate(new Home());
                w.frameMain.Content = new Home();
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
