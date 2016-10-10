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
using Ksora.Model;


namespace Ksora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow() {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            gInicio.Visibility = Visibility.Visible;
            gBuscar.Visibility = Visibility.Hidden;
            gActualizar.Visibility = Visibility.Hidden;
            gInventario.Visibility = Visibility.Hidden;
            gAjustes.Visibility = Visibility.Hidden;

        }

        private void bt_Buscar_Click(object sender, RoutedEventArgs e)
        {
            gInicio.Visibility = Visibility.Hidden;
            gBuscar.Visibility = Visibility.Visible;
            gActualizar.Visibility = Visibility.Hidden;
            gInventario.Visibility = Visibility.Hidden;
            gAjustes.Visibility = Visibility.Hidden;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            gInicio.Visibility = Visibility.Hidden;
            gBuscar.Visibility = Visibility.Hidden;
            gActualizar.Visibility = Visibility.Hidden;
            gInventario.Visibility = Visibility.Visible;
            gAjustes.Visibility = Visibility.Hidden;
        }

        private void bt_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            gInicio.Visibility = Visibility.Hidden;
            gBuscar.Visibility = Visibility.Hidden;
            gActualizar.Visibility = Visibility.Visible;
            gInventario.Visibility = Visibility.Hidden;
            gAjustes.Visibility = Visibility.Hidden;
        }

        private void bt_Ajustes_Click(object sender, RoutedEventArgs e)
        {
            gInicio.Visibility = Visibility.Hidden;
            gBuscar.Visibility = Visibility.Hidden;
            gActualizar.Visibility = Visibility.Hidden;
            gInventario.Visibility = Visibility.Hidden;
            gAjustes.Visibility = Visibility.Visible;
        }

        private void Bt_inicio_Click(object sender, RoutedEventArgs e)
        {
            WPF_Venta Ventana_Venta;
            Ventana_Venta = new WPF_Venta();
            Ventana_Venta.Show();

            main.WindowState = WindowState.Minimized;

            








        }


        // private void button_Click(object sender, RoutedEventArgs e) {

        //  string a = "'"+nombreTxt.Text+"'" + "," + "'"+categoriaTxt.Text+"'" + "," + "'"+cantidadTxt.Text+"'";

        //     DbConnection.add(a);

        //}







    }
}
