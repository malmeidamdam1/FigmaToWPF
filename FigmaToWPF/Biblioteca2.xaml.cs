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
    /// Lógica de interacción para Biblioteca2.xaml
    /// </summary>
    public partial class Biblioteca2 : Window
    {
        public Biblioteca2()
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

        private void Menu_Click_Comunidad(object sender, RoutedEventArgs e)
        {
            Comunidad comunidad = new Comunidad();
            comunidad.Show();
            this.Close(); ;
        }

        private void Menu_Click_Soporte(object sender, RoutedEventArgs e)
        {
            Soporte soporte = new Soporte();
            soporte.Show();
            this.Close();
        }

        private void Menu_Click_Buscar(object sender, RoutedEventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Show();
            this.Close();
        }
        private void Boton_Click_Actual(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Juego ya desplegado");
        }

        private void Boton_Click_Juego1(object sender, RoutedEventArgs e)
        {
            Biblioteca juego1 = new Biblioteca();
            juego1.Show();
            this.Close();
        }

        private void Boton_Click_Juego3(object sender, RoutedEventArgs e)
        {
            Biblioteca3 juego3 = new Biblioteca3();
            juego3.Show();
            this.Close();

        }
    }
}
