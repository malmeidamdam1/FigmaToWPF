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
    /// Lógica de interacción para Comunidad.xaml
    /// </summary>
    public partial class Comunidad : Window
    {
        public Comunidad()
        {
            InitializeComponent();
        }
        private void Menu_Click_Actual(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ya estas aquí");
        }
        private void Menu_Click_Inicio(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
        private void Menu_Click_Soporte(object sender, RoutedEventArgs e)
        {
            Soporte soporte = new Soporte();
            soporte.Show();
            this.Close();
        }
        private void Menu_Click_Biblioteca(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Show();
            this.Close();
        }

        private void Menu_Click_Buscar(object sender, RoutedEventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Show();
            this.Close();
        }


    }
}
