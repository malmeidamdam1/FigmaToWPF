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

namespace FigmaToWPF
{
    /// <summary>
    /// Lógica de interacción para Biblioteca.xaml
    /// </summary>
    public partial class Biblioteca : Window
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ya estas aquí");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Show();
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("No disponible por el momento");
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Soporte soporte = new Soporte();
            soporte.Show();
            this.Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Biblioteca2 biblio2 = new Biblioteca2();
            biblio2.Show();
            this.Close();
        }

    }
}
