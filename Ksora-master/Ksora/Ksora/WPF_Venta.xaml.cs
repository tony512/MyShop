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

namespace Ksora
{
    /// <summary>
    /// Lógica de interacción para WPF_Venta.xaml
    /// </summary>
    public partial class WPF_Venta : Window
    {
       
        public WPF_Venta()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Today;
            DateTime hora = DateTime.Now;
           

            lbl_hora.Content = fecha.ToString("D") +"\n"+ hora.ToString("hh:mm:ss");




        }
    }
}
