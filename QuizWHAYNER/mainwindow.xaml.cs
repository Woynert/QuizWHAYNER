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
        public Page1 P1 = new Page1();
        public Home P2 = new Home();
        public MainWindow()
        {
            InitializeComponent();
            
            frameMain.Content = P1;// new Page1();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
